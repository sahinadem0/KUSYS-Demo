using System.ComponentModel.DataAnnotations;

namespace KUSYS_Demo.Models
{
    public class Student : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string BirthDate { get; set; }
        public List<StudentCourses>? StudentCourses { get; set; }
    }
}
