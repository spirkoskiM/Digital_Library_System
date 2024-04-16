using DigitalLibrary;

namespace Forma
{
    public class Program
    {
        public static DigitalLibrary.Services.DbWriteRead DbWriterReader;

        public static Employee LogedEmployee;
        [STAThread]
        static void Main()
        {
            DbWriterReader = new DigitalLibrary.Services.DbWriteRead();
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}