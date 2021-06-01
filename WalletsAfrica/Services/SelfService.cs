using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WalletsAfrica.Entities.Self;
using WalletsAfrica.Entities.Useful;
using WalletsAfrica.Infrastructure;

namespace WalletsAfrica.Services
{
    public class SelfService
    {
        public SelfService(IWalletsAfricaClient client)
        {
            this.client = client;
        }

        IWalletsAfricaClient client;
        public async Task<BalanceResponse> GetBalanceAsync(string currency)
        {
            var response = await client.Post("/self/balance", new BalanceRequest { Currency = currency, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<BalanceResponse>(response);
        }

        public async Task<MainTransactionResponse> GetMainTransactionAsync(int skip, int take, string dateFrom, string dateTo, int transactionType, string currency)
        {
            var response = await client.Post("/self/transactions", new MainTransactionRequest { Skip = skip, Take = take, DateFrom = dateFrom, DateTo = dateTo, TransactionType = transactionType, SecretKey = client.SecretKey, Currency = currency  });
            return JsonConvert.DeserializeObject<MainTransactionResponse>(response);
        }


        public async Task<GetWalletsResponse> GetWalletsAsync(int skip, int take)
        {
            var response = await client.Post("/self/users", new GetWalletsRequest { Take = take, Skip = skip, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<GetWalletsResponse>(response);
        }

    }
}
