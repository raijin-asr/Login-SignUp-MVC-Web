using Microsoft.AspNetCore.Identity;

namespace Login_Signup_MVC_web.Models
{
    public class Users: IdentityUser
    {
        public string FullName { get; set; }
    }
}
