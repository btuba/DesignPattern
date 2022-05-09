using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Factory
{
    internal class CreditCardCreator : ICreator
    {
        public IPayable GetPayable()
        {
            return new CreditCard();
        }
    }
}
