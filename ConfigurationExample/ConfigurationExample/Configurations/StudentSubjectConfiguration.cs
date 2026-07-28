using ConfigurationExample.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationExample.Configurations
{
    internal class StudentSubjectConfiguration : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> builder)
        {
            builder
                .HasKey(ss => new { ss.StudentId, ss.SubjectId });//Composite key


            builder
                .HasOne(ss => ss.Student)
                .WithMany(stu => stu.StudentSubjects)
                .HasForeignKey(ss => ss.StudentId);


            builder
               .HasOne(ss => ss.Subject)
               .WithMany(sub => sub.StudentSubjects)
               .HasForeignKey(ss => ss.SubjectId);


        }
    }
}
