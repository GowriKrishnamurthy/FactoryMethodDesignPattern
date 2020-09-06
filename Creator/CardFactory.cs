﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Creator
{
    /// <summary>  
    /// The 'Creator' Abstract Class  
    /// </summary>  
    abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}