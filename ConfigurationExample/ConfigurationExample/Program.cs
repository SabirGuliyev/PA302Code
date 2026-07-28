using ConfigurationExample.Common;

namespace ConfigurationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagementApplication app = new ManagementApplication(new ServiceInitializer());
            app.Run();

        }
    }
}
