using System.Text.Json.Serialization;

namespace CloudDbTestSPD011.Model
{
    /// <summary>
    /// Курс
    /// </summary>
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<Student> Students { get; set; }
        public Course()
        {
            Students = new List<Student>();
            Name = string.Empty;
        }
    }
}
