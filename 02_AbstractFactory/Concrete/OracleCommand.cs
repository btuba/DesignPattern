using _02_AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Concrete
{
    internal class OracleCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine($"Oracle sorgusu çalıştırıldı : {Query}");
        }
    }
}
