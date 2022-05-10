using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Builder.Lib.v4
{
    public interface IComputerBuilder
    {
        IComputerBuilder BuildCPU(string cpu);
        IComputerBuilder BuildGPU(string gpu);
        Computer Build();
        //Computer BuildCPU(string cpu);
    }
}
