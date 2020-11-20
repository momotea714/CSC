using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModel
{
    public class UserGroupViewModel
    {
        public static List<SelectListItem> GetSelectList()
        {
            return new List<SelectListItem> {
            new SelectListItem{ Value = "",Text = ""},
            new SelectListItem{ Value = "グループ1",Text = "グループ1"},
            new SelectListItem{ Value = "グループ2",Text = "グループ2"},
            new SelectListItem{ Value = "グループ3",Text = "グループ3"},
            };
        }
    }
}
