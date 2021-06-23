using System;
using System.Collections.Generic;
using System.Text;

namespace DbPersister_With_DIP
{
    public interface ILogger
    {
        void Write(string message);
    }
}
