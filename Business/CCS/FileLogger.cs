using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
    /*Logları bir dosyaya almak*/
    public class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosya Loglandı.");
        }
    }
}
