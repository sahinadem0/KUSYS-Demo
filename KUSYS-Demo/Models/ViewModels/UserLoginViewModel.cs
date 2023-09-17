using System.ComponentModel.DataAnnotations;

namespace KUSYS_Demo.Models.ViewModels
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Please Enter Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }
    }
}
