namespace hometask_Indexer_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Exchange exchange = new Exchange();

            Console.WriteLine("AZN Deyerini daxil edin:");
            double aznAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valyuta Sechin (Usd, Eur, Try):");
            Currency currency;
            if (!Enum.TryParse(Console.ReadLine(), true, out currency))
            {
                Console.WriteLine("Yalnish Valutya secimi ");
                return;
            }

            double convertedAmount = exchange.ConvertCurrency(currency, aznAmount);
            Console.WriteLine($"{aznAmount}  Manat  {currency}  Valutyasine cevrildi  {convertedAmount}  mebleg  ");
        }
    }
}
