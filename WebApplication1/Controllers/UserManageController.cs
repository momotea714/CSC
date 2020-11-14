using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repository.Interface;
using WebApplication1.Service;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class UserManageController : Controller
    {
        private readonly IApplicationUserRepositoryAsync _applicationUser;
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IRazorRenderService _renderService;
        private readonly ILogger<UserManageController> _logger;
        private readonly ApplicationDbContext _context;

        public UserManageController(ILogger<UserManageController> logger
            , ApplicationDbContext context
            , IApplicationUserRepositoryAsync applicationUser
            , UserManager<ApplicationUser> userManager
            , IUnitOfWork unitOfWork
            , IRazorRenderService renderService)
        {
            _logger = logger;
            _context = context;
            _applicationUser = applicationUser;
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _renderService = renderService;
        }
        public IEnumerable<ApplicationUser> applicationUsers { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Download()
        {
            // CSV ファイル名
            string csvFileName = "ユーザーデータ.csv";
            // メモリを確保する
            using (var memory = new MemoryStream())
            using (var writer = new StreamWriter(memory, Encoding.GetEncoding("shift-jis")))
            using (var csv = new CsvWriter(writer, new CultureInfo(0x0411, false)))
            {
                var applicationUsers = await ApplicationUserViewModel.GetAll(_context, _applicationUser);
                csv.WriteRecords(applicationUsers);
                writer.Flush();
                // CSVファイルとして出力する
                return File(memory.ToArray(), "text/csv", csvFileName);
            }
        }

        //public byte[] GetCsvContents()
        //{
        //    var applicationUsers = ApplicationUserViewModel.GetAll(_context, _applicationUser);

        //    using (var memory = new MemoryStream())
        //    using (var writer = new StreamWriter(memory))
        //    using (var csv = new CsvWriter(writer, new CultureInfo(0x0411, false)))
        //    {
        //        csv.WriteRecords((System.Collections.IEnumerable)applicationUsers);
        //        writer.Flush();
        //        return memory.ToArray();
        //    }
        //}

        public async Task<IActionResult> OnGetViewAllPartial()
        {
            var users = await ApplicationUserViewModel.GetAll(_context, _applicationUser);
            return new PartialViewResult
            {
                ViewName = "_ViewAll",
                ViewData = new ViewDataDictionary<IEnumerable<ApplicationUserViewModel>>(ViewData, users.ToList())
            };
        }

        public async Task<IActionResult> GetCreateOrEdit(string id = null)
        {
            ViewBag.Roles = RoleViewModel.GetSelectList();
            ViewBag.UserGroups = UserGroupViewModel.GetSelectList();

            if (string.IsNullOrEmpty(id))
            {
                return PartialView("_CreateOrEdit", new ApplicationUserViewModel());
            }
            else
            {
                var u = await ApplicationUserViewModel.Get(_context, _applicationUser, id);
                return PartialView("_CreateOrEdit", u);
            }
        }
        public async Task<IActionResult> CreateOrEdit(string id, ApplicationUserViewModel applicationUser)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(id))
                {
                    var user = new ApplicationUser
                    {
                        UserName = applicationUser.UserId,
                        DisplayUserName = applicationUser.DisplayUserName,
                        GroupName = applicationUser.GroupName,
                        Password = applicationUser.Password,
                        IsValid = applicationUser.IsValid,
                        CreateDatetime = DateTime.Now,
                        UpdateDatetime = DateTime.Now
                    };

                    var result = await _userManager.CreateAsync(user, applicationUser.Password);
                    user = _context.Users.First(x => x.UserName == applicationUser.UserId);
                    _context.UserRoles.Add(new IdentityUserRole<string> { RoleId = applicationUser.UserRoleId, UserId = user.Id });
                    await _context.SaveChangesAsync();

                }
                else
                {
                    var user = _context.Users.First(x => x.Id == id);
                    user.UserName = applicationUser.UserId;
                    user.DisplayUserName = applicationUser.DisplayUserName;
                    user.GroupName = applicationUser.GroupName;
                    user.Password = applicationUser.Password;
                    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, applicationUser.Password);
                    user.IsValid = applicationUser.IsValid;
                    user.UpdateDatetime = DateTime.Now;
                    _context.Users.Update(user);

                    var role = _context.UserRoles.First(x => x.UserId == id);
                    _context.UserRoles.Remove(role);
                    _context.UserRoles.Add(new IdentityUserRole<string> { RoleId = applicationUser.UserRoleId, UserId = applicationUser.Id });

                    await _context.SaveChangesAsync();
                }

                return await OnGetViewAllPartial();
            }
            else
            {
                return await OnGetViewAllPartial();
            }
        }
        public async Task<IActionResult> Delete(string id)
        {
            var applicationUser = await _context.Users.FirstAsync(x => x.Id == id);
            await _applicationUser.DeleteAsync(applicationUser);
            var role = _context.UserRoles.First(x => x.UserId == id);
            _context.UserRoles.Remove(role);
            await _unitOfWork.Commit();
            return await OnGetViewAllPartial();
        }
    }
}
