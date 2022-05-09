using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Singleton
{
    internal class Logger
    {
        static Logger _logger;
        static object _lock = new object();

        protected Logger()
        {

        }
        public static Logger GetLogger()
        {
            if (_logger == null)
            {
                lock (_lock)
                {
                    if ( _logger == null )
                        _logger = new Logger();
                }
            }
            return _logger;
        }
    }
}
