using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Factory.Lib
{
    internal class FileLoggerFactory : ILoggerFactory
    {
        public ILogger Create()
        {
            return new FileLogger();
        }
    }
}
