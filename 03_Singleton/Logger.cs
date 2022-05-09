using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Singleton
{
    internal class Logger
    {
        // idiom 

        public static readonly Logger Instance = new Logger();
        protected Logger()
        {
        }
    }
}
