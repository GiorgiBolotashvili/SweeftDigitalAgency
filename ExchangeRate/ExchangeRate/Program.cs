using System;


namespace ExchangeRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" 1 EURO equals {ExchangeRate("EUR", "USD")} USD");
            Console.WriteLine();
            Console.WriteLine($" 1 USD equals {ExchangeRate("USD", "JPY")} JPY");
            Console.WriteLine();
            Console.WriteLine($" 1 USD equals {ExchangeRate("USD", "TRY")} TRY");
            Console.WriteLine();
            Console.WriteLine($" 1 GBP equals {ExchangeRate("GBP", "GEL")} GEL");
        }
        private static double ExchangeRate(string from, string to)
        {
            ListOfAllCurrency currency = new ListOfAllCurrency();
            double fromRate = 0, toRate = 0;
            foreach (var item in currency.Currencies)
            {
                if (item.Code == from)
                    fromRate = item.Rate;
                if (item.Code == to)
                    toRate = item.Rate;
            }
            return Math.Round(fromRate / toRate, 4);
        }
    }
}
