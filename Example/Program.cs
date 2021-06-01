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
                var transactions = selfService.GetMainTransactionAsync(0, 5, "2021-02-15", "2021-05-21", 1, "NGN").Result;
                Console.WriteLine($"{transactions.Data.Transactions.Length} transactions");
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

