using System;
using System.Collections.Generic;
using System.Text;

namespace DbPersister_With_DIP
{
    public class DbLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine("DB Log - "+message);
        }
    }
}
