using System;
using System.Collections.Generic;
using System.Text;

namespace DbPersister_With_DIP
{
    public class DbPersister
    {
        ILogger _loggerDependency;
        public DbPersister(ILogger loggerDependency)
        {
            _loggerDependency = loggerDependency;
        }
        public void CreateLog()
        {
            _loggerDependency.Write("Testing loosely coupled arch");
        }
    }
}
