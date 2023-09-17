namespace KUSYS_Demo.Models
{
    public class StudentCourses : Entity
    {
        public int StudentId { get; set; }
        public Student Student { get; set;}
        public int CourseId { get; set; }
        public Course Course { get; set;}
    }
}
