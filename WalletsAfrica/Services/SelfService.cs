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

    }
}
