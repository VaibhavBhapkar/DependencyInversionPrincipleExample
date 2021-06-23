using DbPersister_Without_DIP;
using System;

namespace DependencyInversionPrincipleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DbPersister dbPersister = new DbPersister();
            dbPersister.CreateLog();
        }
    }
}
