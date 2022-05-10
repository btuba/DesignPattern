using _01_Builder.Lib.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Builder.Lib.v2
{
    public class PolicyBuilder2 : IPolicyBuilder2
    {
        public List<Coverage> BuildCoverage(decimal price)
        {
            return new List<Coverage>() 
            { 
                new Coverage() { Price = price } 
            };   
        }

        public Insured BuildInsured(string name)
        {
            return new Insured() { Name = name };
        }

        public Insurer BuildInsurer(string name)
        {
            return new Insurer() { Name = name};
        }

        public Policy BuildPolicy(string insuredName, string insurerName, decimal price)
        {
            return new Policy() 
            { 
                Insured = BuildInsured(insuredName),
                Insurer = BuildInsurer(insurerName),
                Coverages = BuildCoverage(price)
            };
        }
    }
}
