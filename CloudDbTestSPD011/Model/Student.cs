namespace CloudDbTestSPD011.Model
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Course { get; set; }

        public Student()
        {
            Name = string.Empty;
            Surname = string.Empty;
            Course = string.Empty;
        }

    }
}
