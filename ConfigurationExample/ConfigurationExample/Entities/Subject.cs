
namespace ConfigurationExample.Entities
{
    internal class Subject:BaseEntity
    {
        public string Name { get; set; }
        public List<StudentSubject> StudentSubjects { get; set; }

        //public List<Student> Students { get; set; }

    }
}
