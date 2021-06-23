using System;
using System.Collections.Generic;
using System.Text;

namespace DbPersister_With_DIP
{
    public class ConsoleLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine("Console Log -"+message);
        }
    }
}
