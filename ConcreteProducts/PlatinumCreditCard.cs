using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.ConcreteCreators
{
    class PlatinumCreditCard : CreditCard
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

        public PlatinumCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Platinum";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge; 
        }
    }
}
