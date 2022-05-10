using _02_AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Concrete
{
    internal class SqlConnection : Connection
    {
        public override void Close()
        {
            Console.WriteLine($"MSSQL bağlantısı açıldı : {ConnectionString}");
        }

        public override void Open()
        {
            Console.WriteLine($"MSSQL bağlantısı kapandı: {ConnectionString}");
        }
    }
}
