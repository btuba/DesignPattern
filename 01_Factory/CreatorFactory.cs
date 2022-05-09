using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Factory
{
    // IoC Container
    internal static class CreatorFactory
    {
        public static ICreator GetCreditCardCreator()
        {
            return new CreditCardCreator();
        }
        public static ICreator GetTransferCreator(string iban)
        {
            return new TransferCreator(iban);
        }

    }
}
