using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Factory
{
    internal class TransferCreator : ICreator
    {
        private string Iban { get; set; }
        public TransferCreator(string iban)
        {
            this.Iban = iban;
        }
        public IPayable GetPayable()
        {
            return new Transfer(this.Iban);
        }
    }
}
