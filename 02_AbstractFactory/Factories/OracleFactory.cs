using _02_AbstractFactory.Abstract;
using _02_AbstractFactory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Factories
{
    internal class OracleFactory : IDbFactory
    {
        public Command GetCommand()
        {
            return new OracleCommand();
        }

        public Connection GetConnection()
        {
            return new OracleConnection();
        }
    }
}
