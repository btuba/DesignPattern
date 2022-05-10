using _02_AbstractFactory.Abstract;
using _02_AbstractFactory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Factories
{
    internal class SqlFactory : IDbFactory
    {
        public Command GetCommand()
        {
            return new SqlCommand();
        }

        public Connection GetConnection()
        {
            return new SqlConnection();
        }
    }
}
