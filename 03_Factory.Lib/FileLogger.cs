using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Factory.Lib
{
    internal class FileLogger : ILogger
    {
        public string Log(string info)
        {
            return $"File Logger : {info}";
        }
    }
}
