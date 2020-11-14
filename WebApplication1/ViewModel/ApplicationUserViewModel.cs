using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repository.Interface;

namespace WebApplication1.ViewModel
{
    public class ApplicationUserViewModel
    {
        public string Id { get; set; }
        public string GroupName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string DisplayUserName { get; set; }
        public string UserRoleId { get; set; }
        public string UserRoleName { get; set; }
        public bool IsValid { get; set; }
        public DateTime CreateDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }

        public static async Task<IEnumerable<ApplicationUserViewModel>> GetAll(ApplicationDbContext context, IApplicationUserRepositoryAsync applicationUser)
        {
            var roles = context.UserRoles.ToList();
            var r = context.Roles.ToList();

            var applicationUsers = await applicationUser.GetAllAsync();
            return applicationUsers.OrderByDescending(x => x.UpdateDatetime).Select(x => ToViewModel(x, r, roles));
        }

        public static async Task<ApplicationUserViewModel> Get(ApplicationDbContext context, IApplicationUserRepositoryAsync applicationUser, string id)
        {
            var u = await context.Users.FirstAsync(x => x.Id == id);
            var roles = context.UserRoles.ToList();
            var r = context.Roles.ToList();

            return ToViewModel(u, r, roles);
        }

        public static ApplicationUserViewModel ToViewModel(ApplicationUser applicationUser
            , IEnumerable<IdentityRole> r
            , IEnumerable<IdentityUserRole<string>> roles)
        {
            return new ApplicationUserViewModel
            {
                Id = applicationUser.Id,
                GroupName = applicationUser.GroupName,
                UserId = applicationUser.UserName,
                Password = applicationUser.Password,
                DisplayUserName = applicationUser.DisplayUserName,
                UserRoleId = roles.First(y => applicationUser.Id == y.UserId).RoleId,
                UserRoleName = r.First(z => z.Id == roles.First(y => applicationUser.Id == y.UserId).RoleId).NormalizedName,
                IsValid = applicationUser.IsValid,
                CreateDatetime = applicationUser.CreateDatetime,
                UpdateDatetime = applicationUser.UpdateDatetime
            };
        }

        public ApplicationUser ToModel()
        {
            return new ApplicationUser
            {
                Id = Id,
                GroupName = GroupName,
                UserName = UserId,
                Password = Password,
                DisplayUserName = DisplayUserName,
                IsValid = IsValid,
                CreateDatetime = CreateDatetime,
                UpdateDatetime = UpdateDatetime,
            };
        }

    }
}
