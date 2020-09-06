using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.ConcreteCreators
{
    class TitaniumCreditCard : CreditCard
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

        public TitaniumCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Titanium";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge; 
        }
    }
}
