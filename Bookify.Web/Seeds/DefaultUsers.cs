using Microsoft.AspNetCore.Identity;

namespace Bookify.Web.Seeds
{
    public static class DefaultUsers
    {
        public static async Task SeedAdminUserAsync(UserManager<ApplicationUser> userManager)
        {
            ApplicationUser admin = new()
            {
                UserName = "Essam",
                Email = "essames949@gmail.com",
                FullName = "Essam",
                EmailConfirmed = true
            };

            var user = await userManager.FindByEmailAsync(admin.Email);

            if(user is null)
            {
                await userManager.CreateAsync(admin, "Asd@1234");
                await userManager.AddToRoleAsync(admin, AppRoles.Admin);
            }
        }
    }
}