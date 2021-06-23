using System;
using System.Collections.Generic;
using System.Text;

namespace DbPersister_Without_DIP
{
    public class DbPersister
    {
        ConsoleLogger consoleLogger = new ConsoleLogger();
        public void CreateLog()
        {
            consoleLogger.Write("Testing Tightly Coupled Arch");
        }
    }
}
