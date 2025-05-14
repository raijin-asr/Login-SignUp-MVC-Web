using Login_Signup_MVC_web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Login_Signup_MVC_web.Data
{
    public class AppDbContext: IdentityDbContext<Users>
    {
         public AppDbContext(DbContextOptions options) : base(options) { 
        
        }
    }
}
