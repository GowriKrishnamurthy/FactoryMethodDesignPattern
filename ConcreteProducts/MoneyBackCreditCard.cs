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
        private readonly int _creditLimit;
        private readonly int _annualCharge;
        private readonly string _cardType;

        public override string CardType { get; }
        public override int CreditLimit { get; set; }
        public override int AnnualCharge { get; set; }

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "MoneyBack";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge; 
        }
    }
}
