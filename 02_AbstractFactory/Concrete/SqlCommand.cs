using _02_AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Concrete
{
    internal class SqlCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine($"MSSQL sorgusu çalıştırıldı : {Query}");
        }
    }
}
