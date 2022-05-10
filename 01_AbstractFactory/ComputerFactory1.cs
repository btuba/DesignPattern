using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AbstractFactory
{
    internal class ComputerFactory1 : IFactory
    {
        public Monitor CreateMonitor()
        {
            return new Samsung();
        }

        public Processor CreateProcessor()
        {
            return new Intel();
        }
    }
}
