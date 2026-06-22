using ADOExample.DAL;
using ADOExample.Models;
using ADOExample.Services;
using System.Data;
using System.Data.SqlClient;

namespace ADOExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ADO example
            //string connectionString = "server=MSI;database=ADOPA302;trusted_connection=true;integrated security=true;";

            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();

            //string query = "SELECT * FROM Students";

            //DataTable table = new DataTable();

            //SqlDataAdapter adapter = new SqlDataAdapter(query,connection);

            //adapter.Fill(table);
            //connection.Close();



            //List<Student> students = new();
            //foreach(DataRow item in table.Rows)
            //{
            //    students.Add(new Student
            //    {
            //        Id = (int)item["Id"],
            //        Name = item["Name"].ToString(),
            //        Surname = item["Surname"].ToString(),
            //        Age = (int)item["Age"]
            //    });
            //    //Console.WriteLine(item[0]+" " + item[1]+" " + item[2]+" " + item[3]);
            //    //Console.WriteLine(item["Id"]+" " + item["Surname"]+" " + item["Name"]+" " + item["Age"]);
            //}




            //foreach (Student student in students)
            //{
            //    if (student.Age < 25)
            //    {
            //        Console.WriteLine(student.Name+" "+student.Surname);
            //    }
            //} 

            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student.Id+" "+student.Name);
            //}



            //string cmdText = "INSERT INTO Students VALUES('Nasib','Shahverdiyev',28)";
            //connection.Open();

            //SqlCommand cmd = new SqlCommand(cmdText, connection);

            //int result = cmd.ExecuteNonQuery();
            //connection.Close();

            //if (result > 0)
            //{
            //    Console.WriteLine("Command successfully completed");
            //}
            //else
            //{
            //    Console.WriteLine("Error occured");
            //}

            #endregion


            Sql sql = new Sql();
            StudentService studentService = new StudentService(sql);




            Student student = new Student
            {
                Name = "Tunar",
                Surname = "Aliyev",
                Age = 20
            };

            studentService.Delete(1);

            //studentService.Add(student);

            foreach (Student std in studentService.GetAll())
            {
                Console.WriteLine($"{std.Name} {std.Surname}");
            }

           


        }
    }
}
