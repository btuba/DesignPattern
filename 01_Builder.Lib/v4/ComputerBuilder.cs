using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Builder.Lib.v4
{
    public class ComputerBuilder : IComputerBuilder
    {
        Computer computer;
        public ComputerBuilder()
        {
            computer = new Computer();
        }

        public Computer Build()
        {
            return computer;
        }

        public IComputerBuilder BuildCPU(string cpu)
        {
            if (computer.GPU is null)
                throw new Exception("beni en son çağır");

            computer.CPU = cpu;
            return this;
        }

        public IComputerBuilder BuildGPU(string gpu)
        {
            computer.GPU = computer.CPU;
            return this;
        }


        //public Computer BuildCPU(string cpu)
        //{
        //    if (computer.GPU is null)
        //        throw new Exception("beni en son çağır");

        //    computer.CPU = cpu;
        //    return computer;
        //}
    }
}
