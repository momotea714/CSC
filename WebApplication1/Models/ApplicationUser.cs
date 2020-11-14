using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Password { get; set; }
        public string DisplayUserName { get; set; }
        public bool IsValid { get; set; }
        public string GroupName { get; set; }
        public DateTime CreateDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        //public int UserGroupId { get; set; }
        public virtual UserGroup UserGroup { get; set; }

        public async Task CreateUserAsync(string password, UserManager<ApplicationUser> userManager)
        {
            var exists = await userManager.FindByEmailAsync(Email);
            if (exists == null)
                await userManager.CreateAsync(this, password);
        }
    }
}
