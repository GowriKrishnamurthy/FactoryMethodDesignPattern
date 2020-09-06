using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.ConcreteCreators
{
    class MoneyBackCreditCard: CreditCard
    {
        /// <summary>  
        /// A 'ConcreteProduct' class  
        /// </summary>
        public string CardType { get; }

        public int CreditLimit { get; set; }

        public int AnnualCharge { get; set; }

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            CardType = "MoneyBack";
            CreditLimit = creditLimit;
            AnnualCharge = annualCharge;
        }
    }
}
