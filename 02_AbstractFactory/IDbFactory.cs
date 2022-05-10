using _02_AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory
{
    interface IDbFactory
    {
        Connection GetConnection();
        Command GetCommand();
    }
}
