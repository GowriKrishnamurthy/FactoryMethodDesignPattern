using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.ConcreteCreators
{
    class PlatinumCreditCard : CreditCard
    {
        public PlatinumCreditCard(int creditLimit, int annualCharge)
        {
            CardType = "Platinum";
            CreditLimit = creditLimit;
            AnnualCharge = annualCharge;
        }

        public string CardType { get; }

        public int CreditLimit { get; set; }

        public int AnnualCharge { get; set; }
    }
}
