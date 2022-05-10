using _02_AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory
{
    class DbClient
    {
        Connection _connection;
        Command _command;
        IDbFactory _dbFactory;

        public DbClient(IDbFactory dbFactory, string connectionString)
        {
            _dbFactory = dbFactory;
            _connection = dbFactory.GetConnection();
            _command = dbFactory.GetCommand();
            _connection.ConnectionString = connectionString;
        }

        public void DoJob(string query)
        {
            _command.Query = query;
            _connection.Open();
            _command.Execute();
            _connection.Close();
        }
    }
}
