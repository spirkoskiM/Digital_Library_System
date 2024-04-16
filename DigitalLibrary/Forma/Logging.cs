using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    internal class Logging
    {
        public Logging() { }

        public static void ExceptionHandling(Exception ex)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExceptionFile.txt");

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}
