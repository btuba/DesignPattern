using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Builder.Lib.v1
{
    public class PolicyBuilder : IPolicyBuilder
    {
        Policy policy;

        void BuildInsurer(string name)
        {
            Insurer insurer = new Insurer() { Name = name};
            policy.Insurer = insurer;
        }

        void BuildInsured(string name)
        {
            Insured insured = new Insured() { Name = name };
            policy.Insured = insured;
        }

        void BuildCoverages()
        {
            List<Coverage> coverages = new List<Coverage>();
            coverages.Add(new Coverage() { Price = 1000 });
            policy.Coverages = coverages;
        }

        // private da olabilir
        public Policy BuildPolicy(string insuredName, string insurerName)
        {
            policy = new();
            BuildInsured(insuredName);
            BuildInsurer(insurerName);
            BuildCoverages();
            return policy;
        }
    }
}
