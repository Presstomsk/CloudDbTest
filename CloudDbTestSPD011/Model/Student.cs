namespace CloudDbTestSPD011.Model
{
    /// <summary>
    /// Студент
    /// </summary>
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int? CourseId { get; set; }
        
        public Course Course { get; set; }

        public Student()
        {
            Name = string.Empty;
            Surname = string.Empty;
        }

    }
}
