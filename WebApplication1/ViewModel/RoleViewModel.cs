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
            new SelectListItem{ Value = "",Text = ""},
            new SelectListItem{ Value = "管理者",Text = "管理者"},
            new SelectListItem{ Value = "リーダー",Text = "リーダー"},
            new SelectListItem{ Value = "一般",Text = "一般"},
            };
        }
    }
}
