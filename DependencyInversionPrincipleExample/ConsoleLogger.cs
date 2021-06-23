using System;
using System.Collections.Generic;
using System.Text;

namespace DbPersister_Without_DIP
{
    public class ConsoleLogger
    {
        public void Write(string Message)
        {
            Console.WriteLine(Message);
        }

    }
}
