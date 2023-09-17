using Microsoft.AspNetCore.Identity;

namespace KUSYS_Demo.Models
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
