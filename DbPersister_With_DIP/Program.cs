using System;

namespace DbPersister_With_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger _loggerRef = new ConsoleLogger();
            DbPersister dbPersister = new DbPersister(_loggerRef);

            dbPersister.CreateLog();

            _loggerRef = new DbLogger();
            dbPersister = new DbPersister(_loggerRef);

            dbPersister.CreateLog();
        }
    }
}
