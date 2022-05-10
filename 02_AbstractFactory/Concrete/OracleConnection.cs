using _02_AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Concrete
{
    internal class OracleConnection : Connection
    {
        public override void Close()
        {
            Console.WriteLine($"Oracle bağlantısı açıldı : {ConnectionString}");
        }

        public override void Open()
        {
            Console.WriteLine($"Oracle bağlantısı kapandı: {ConnectionString}");
        }
    }
}
