

namespace ConfigurationExample.Entities
{
    internal class Student:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public List<StudentSubject> StudentSubjects { get; set; }
        //public List<Subject> Subjects { get; set; }


    }
}
