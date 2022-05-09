using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Factory
{
    internal class CreditCard : IPayable
    {
        public string Pay(decimal amount)
        {
            return $"{amount} tl paid with credit card.";
        }
    }
}
