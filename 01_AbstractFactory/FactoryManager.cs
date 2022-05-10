using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AbstractFactory
{
    internal class FactoryManager
    {
        private Dictionary<FactoryTypes, IFactory> _factories;

        public FactoryManager()
        {
            _factories = new Dictionary<FactoryTypes, IFactory>();
            _factories.Add(FactoryTypes.ComputerFactory1,new ComputerFactory1());
            _factories.Add(FactoryTypes.ComputerFactory2,new ComputerFactory2());
        }

        public IFactory CreateFactory(FactoryTypes factoryType)
        {
            return _factories[factoryType];
        }
    }

    public enum FactoryTypes
    {
        ComputerFactory1,
        ComputerFactory2
    }
}
