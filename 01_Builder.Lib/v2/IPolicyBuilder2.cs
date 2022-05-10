using _01_Builder.Lib.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Builder.Lib.v2
{
    public interface IPolicyBuilder2
    {
        Insurer BuildInsurer(string name);
        Insured BuildInsured(string name);
        List<Coverage> BuildCoverage(decimal price);
        Policy BuildPolicy(string insuredName, string insurerName, decimal price);
    }
}
