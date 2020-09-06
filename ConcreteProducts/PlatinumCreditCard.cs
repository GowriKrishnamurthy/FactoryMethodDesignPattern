using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.ConcreteCreators
{
    class PlatinumCreditCard : ICreditCard
    {
        public PlatinumCreditCard(int creditLimit, int annualCharge)
        {
            CreditLimit = creditLimit;
            AnnualCharge = annualCharge;
        }

        public string CardType { get; } = "Platinum";

        public int CreditLimit { get; set; }

        public int AnnualCharge { get; set; }
    }
}
