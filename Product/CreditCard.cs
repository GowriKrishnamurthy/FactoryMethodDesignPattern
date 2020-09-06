using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    /// <summary>  
    /// The 'Product' Abstract Class  
    /// </summary>  
    interface CreditCard
    {
        string CardType { get; }
        int CreditLimit { get; set; }
        int AnnualCharge { get; set; }
    }

}
