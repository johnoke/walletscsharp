using System;
using WalletsAfrica.Infrastructure;
using WalletsAfrica.Services;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IWalletsAfricaClient client = new WalletsAfricaClient("XXXXXXX", "YYYYYY", true);
            SelfService selfService = new SelfService(client);
            try
            {
                var transactions = selfService.GetTransactionsAsync("NGN", 0, Convert.ToDateTime("2021/01/01"), Convert.ToDateTime("2021/06/01"), 0, 100).Result;
                Console.WriteLine($"{transactions.Data.Transactions.Count} transactions");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                Console.ReadKey();
            }
        }
    }
}

