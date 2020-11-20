using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
    public class AllocationController : Controller
    {
        private readonly IApplicationUserRepositoryAsync _applicationUser;
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IRazorRenderService _renderService;
        private readonly ILogger<UserManageController> _logger;
        private readonly ApplicationDbContext _context;

        public AllocationController(ILogger<UserManageController> logger
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

        public IActionResult Index()
        {
            return View();
        }
    }
}
