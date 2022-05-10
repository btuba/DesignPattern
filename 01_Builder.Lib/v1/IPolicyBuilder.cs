using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Builder.Lib.v1
{
    public interface IPolicyBuilder // Builder
    {
        Policy BuildPolicy(string insuredName, string insurerName);
    }
}
