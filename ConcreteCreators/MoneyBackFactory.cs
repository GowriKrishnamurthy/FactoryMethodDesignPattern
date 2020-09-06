using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodDesignPattern.Creator;

namespace FactoryMethodDesignPattern.ConcreteCreators
{
    /// <summary>  
    /// A 'ConcreteCreator' class  
    /// </summary>  
    class MoneyBackFactory : ICardFactory
    {
        private readonly int _creditLimit;
        private readonly int _annualCharge;

        public MoneyBackFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public  ICreditCard GetCreditCard()
        {
            return new MoneyBackCreditCard(_creditLimit, _annualCharge);
        }
    }
}
