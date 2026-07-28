using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationExample.Models
{
    internal class StudentSubject
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }

        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}
