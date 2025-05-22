using System.ComponentModel.DataAnnotations;

namespace Login_Signup_MVC_web.ViewModels
{
    public class VerifyViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
