using System;
using WalletsAfrica.Infrastructure;
using WalletsAfrica.Services;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IWalletsAfricaClient client = new WalletsAfricaClient("XXXXX", "YYYYY", true);
            SelfService selfService = new SelfService(client);
            try
            {
                var balance = selfService.GetBalanceAsync("NGN").Result;
                Console.WriteLine($"{balance.Data.WalletCurrency} {balance.Data.WalletBalance}");
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
