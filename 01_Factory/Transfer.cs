using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Factory
{
    internal class Transfer : IPayable
    {
        public string Iban { get; set; }
        public Transfer(string iban)
        {
            this.Iban = iban;
        }
        public string Pay(decimal amount)
        {
            return $"{amount} tl paid by money order.";
        }
    }
}
