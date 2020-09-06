using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodDesignPattern.ConcreteCreators;
using FactoryMethodDesignPattern.Creator;

namespace FactoryMethodDesignPattern
{
    /// <summary>  
    /// Factory Pattern Demo  
    /// </summary>   
    class Program
    {
        static void Main(string[] args)
        {
            CardFactory factory = null;
            Console.Write("Enter the card type you would like to visit: ");
            string cardType = Console.ReadLine();

            switch (cardType.ToLower())
            {
                case "moneyback":
                    factory = new MoneyBackFactory(5000, 0);
                    break;
                case "titanium":
                    factory = new TitaniumFactory(10000, 300);
                    break;
                case "platinum":
                    factory = new PlatinumFactory(50000, 500);
                    break;
                default:
                    break;
            }
            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("\n Your card details are : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            Console.ReadKey();
        }
    }
}
