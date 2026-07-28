using OnionPA302.Domain.Enums;

namespace OnionPA302.Domain.Entities
{
    public class Student:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
    }
}
