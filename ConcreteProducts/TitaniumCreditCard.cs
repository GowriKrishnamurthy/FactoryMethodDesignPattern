using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.ConcreteCreators
{
    class TitaniumCreditCard : ICreditCard
    {
        /// <summary>  
        /// A 'ConcreteProduct' class  
        /// </summary>

        public string CardType { get; } = "Titanium";

        public int CreditLimit { get; set; }
        public int AnnualCharge { get; set; }
        public TitaniumCreditCard(int creditLimit, int annualCharge)
        {
            CreditLimit = creditLimit;
            AnnualCharge = annualCharge;
        }
    }
}
