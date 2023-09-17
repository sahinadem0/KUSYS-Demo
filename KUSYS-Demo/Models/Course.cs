namespace KUSYS_Demo.Models
{
    public class Course : Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<StudentCourses> StudentCourses { get; set; }
    }
}
