namespace Project_SelectingStudents.Models
{
    public class MainModel
    {
        public List<ClassModel> Classes { get; set; } = new List<ClassModel>();

        public List<StudentModel> Students { get; set; } = new List<StudentModel>();
    }
}
