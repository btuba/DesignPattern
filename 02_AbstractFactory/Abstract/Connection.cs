using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Abstract
{
    abstract class Connection
    {
        public string ConnectionString { get; set; }
        public abstract void Open();
        public abstract void Close();
    }
}
