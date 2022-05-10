using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Builder.Lib.v1
{
    public class Agency // Director 
    {
        IPolicyBuilder _builder;

        //public Agency(IPolicyBuilder builder)
        //{
        //    // IoC container
        //    // DI
        //    _builder = builder;
        //}

        public Agency()
        {
            _builder = new PolicyBuilder();
        }

        public Policy Construct(string insuredName, string insurerName)
        {
            return _builder.BuildPolicy(insuredName, insurerName);
        }
    }
}
