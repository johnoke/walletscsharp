using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WalletsAfrica.Entities.Self;
using WalletsAfrica.Infrastructure;
using WalletsAfrica.Constants;

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
            var response = await client.Post(Endpoints.BALANCE, new { Currency = currency, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<BalanceResponse>(response);
        }
        public async Task<TransactionResponse> GetTransactionsAsync(string currency, int transactionType, DateTime dateFrom, DateTime dateTo, int skip, int take)
        {
            var response = await client.Post(Endpoints.TRANSACTIONS, new { Skip = skip, Take = take, DateFrom = dateFrom, DateTime = dateTo, Currency = currency, SecretKey = client.SecretKey, TransactionType = transactionType });
            return JsonConvert.DeserializeObject<TransactionResponse>(response);
        }
    }
}
