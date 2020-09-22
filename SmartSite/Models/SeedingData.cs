using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSite.Models
{
    public class SeedingData
    {
        private readonly ApplicationDbContext _context;
        ApplicationUser user;
        //UserStore<ApplicationUser> userStore;
        UserManager<ApplicationUser> userManager;
        RoleManager<IdentityRole> roleManager;

        public SeedingData(ApplicationDbContext context, UserManager<ApplicationUser> _userManager, RoleManager<IdentityRole> _roleManager)
        {
            _context = context;
            //userStore = new UserStore<ApplicationUser>(context);
            userManager = _userManager;
            roleManager = _roleManager;
        }

        public async Task SeedAdminUser()
        {
             user = new ApplicationUser
            {
                UserName = "admin@smartsite.com",
                NormalizedUserName = "admin@smartsite.com".ToUpper(),
                Email = "smartAdmin",
                NormalizedEmail = "smartAdmin".ToUpper(),
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var roleStore = new RoleStore<IdentityRole>(_context);

            if (!_context.Roles.Any(r => r.Name == "Admin") || !_context.Roles.Any(r => r.Name == "User"))
            {
                await roleStore.CreateAsync(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" });
                await roleStore.CreateAsync(new IdentityRole { Name = "User", NormalizedName = "USER" });

            }

            if (!_context.Users.Any(u => u.UserName == user.UserName))
            {

               var password = new PasswordHasher<ApplicationUser>();
               var hashed = password.HashPassword(user, "   ");
               user.PasswordHash = hashed;
               var usrs= _context.Roles.ToList();
               var urs = _context.Users.ToList();
               var userStore = new UserStore<ApplicationUser>(_context);
               await userStore.CreateAsync(user);
                // var d=  await userManager.CreateAsync(user, "smart@ADMINs");
                //var urs = _context.Users.ToList();
                

                if (! await userStore.IsInRoleAsync(user,"ADMIN"))
                    {
                        await userStore.AddToRoleAsync(user, "ADMIN");
                    }

              //  await userStore.AddToRoleAsync(user, "Admin");
            }

            await _context.SaveChangesAsync();

        }
    }
}
