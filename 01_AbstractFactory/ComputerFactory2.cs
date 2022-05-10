using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AbstractFactory
{
    internal class ComputerFactory2 : IFactory
    {
        public Monitor CreateMonitor()
        {
            return new ViewSonic();
        }

        public Processor CreateProcessor()
        {
            return new AMD();
        }
    }
}
