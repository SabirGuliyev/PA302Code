using ADOExample.DAL;
using ADOExample.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExample.Services
{
    internal class StudentService
    {
        private readonly Sql _sql;


        public StudentService(Sql sql)
        {
            _sql = sql;
        }

        public void Delete(int id)
        {
            string cmd = $"DELETE FROM Students WHERE Id={id}";
            _sql.ExecuteCommand(cmd);
        }
        public void Add(Student student)
        {
            string cmdText = $"INSERT INTO Students VALUES('{student.Name}','{student.Surname}',{student.Age})";
            _sql.ExecuteCommand(cmdText);
        }


        public List<Student> GetAll()
        {
           DataTable table= _sql.ExecuteQuery("SELECT * FROM Students");

            List<Student> students = new();

            foreach (DataRow item in table.Rows)
            {
                students.Add(new Student
                {
                    Id = (int)item["Id"],
                    Name = item["Name"].ToString(),
                    Surname = item["Surname"].ToString(),
                    Age = (int)item["Age"]
                });
            }

            return students;
        }
    }
}
