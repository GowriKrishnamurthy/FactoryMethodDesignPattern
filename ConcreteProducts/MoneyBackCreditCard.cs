using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.ConcreteCreators
{
    class MoneyBackCreditCard: ICreditCard
    {
        /// <summary>  
        /// A 'ConcreteProduct' class  
        /// </summary>

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            CreditLimit = creditLimit;
            AnnualCharge = annualCharge;
        }

        public string CardType { get; } = "MoneyBack";

        public int CreditLimit { get; set; }

        public int AnnualCharge { get; set; }
    }
}
