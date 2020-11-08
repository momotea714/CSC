using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModel
{
    public class RoleViewModel
    {
        public static List<SelectListItem> GetSelectList()
        {
            return new List<SelectListItem> {
            new SelectListItem{ Value = "2c5e174e-3b0e-446f-86af-483d56fd7210",Text = "管理者"},
            new SelectListItem{ Value = "2c5e174e-3b0e-446f-86af-483d56fd7211",Text = "リーダー"},
            new SelectListItem{ Value = "2c5e174e-3b0e-446f-86af-483d56fd7212",Text = "一般"},
            };
        }
    }
}
