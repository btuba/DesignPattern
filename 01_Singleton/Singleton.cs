using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Singleton
{
    class Singleton
    {
        static Singleton _instance;

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if(_instance == null)
                _instance = new Singleton();
            return _instance;
        }
    }
}
