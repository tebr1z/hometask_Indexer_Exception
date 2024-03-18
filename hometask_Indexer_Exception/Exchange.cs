using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_Indexer_Exception
{
    public class Exchange
    {
        public double ConvertCurrency(Currency currency, double aznAmount)
        {
            double convertedAmount = 0;

            switch (currency)
            {
                case Currency.Usd:
                    convertedAmount = aznAmount * 0.59;
                    break;
                case Currency.Eur:
                    convertedAmount = aznAmount * 0.49;
                    break;
                case Currency.Try:
                    convertedAmount = aznAmount * 7.03;
                    break;
                default:
                    Console.WriteLine("Yanlish valutya");
                    break;
            }

            return convertedAmount;
        }
    }
}
