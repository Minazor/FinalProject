using System;

namespace Business.CCS
{
    /*Logları bir veritabanına almak */
    public class DatabaseLoger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı.");
        }
    }
}
