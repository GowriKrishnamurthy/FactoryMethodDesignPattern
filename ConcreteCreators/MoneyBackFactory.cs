﻿using System;
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
    class MoneyBackFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public MoneyBackFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public  CreditCard GetCreditCard()
        {
            return new MoneyBackCreditCard(_creditLimit, _annualCharge);
        }
    }
}
