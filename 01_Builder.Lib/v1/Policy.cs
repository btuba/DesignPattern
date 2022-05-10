using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Builder.Lib.v1
{
    public class Policy // Product
    {
        public Insurer Insurer { get; set; }
        public Insured Insured { get; set; }
        public List<Coverage> Coverages { get; set; }

        public string Print()
        {
            return $"Policy printed. Insurer: {Insurer.Name}, Insured: {Insured.Name}";
        }
    }
}
