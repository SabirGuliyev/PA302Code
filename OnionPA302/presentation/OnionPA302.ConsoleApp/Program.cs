using OnionPA302.ConsoleApp;
using OnionPA302.Persistence;

var studentService = ServiceRegistration.GetStudentService();

var app = new StudentManagement(studentService);
app.Run();
