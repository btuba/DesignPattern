using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Abstract
{
    abstract class Command
    {
        // public Connection Connection { get; set; }
        public string Query { get; set; }
        public abstract void Execute();
    }
}
