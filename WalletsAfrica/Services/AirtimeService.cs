using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WalletsAfrica.Constants;
using WalletsAfrica.Entities.Airtime;
using WalletsAfrica.Entities.Payout;
using WalletsAfrica.Entities.Useful;
using WalletsAfrica.Infrastructure;

namespace WalletsAfrica.Services
{
    public class AirtimeService
    {
        private readonly IWalletsAfricaClient client;

        public AirtimeService(IWalletsAfricaClient client)
        {
            this.client = client;
        }

        public async Task<AirtimeProviderResponse> GetAirtimeProviders()
        {
            var response = await client.Post(Endpoints.AIRTIMEPROVIDERS, new {  SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<AirtimeProviderResponse>(response);
        }

        public async Task<GenericResponse> AirtimePurchase(string Code, string PhoneNumber, decimal Amount)
        {
            var response = await client.Post(Endpoints.AIRTIMEPURCHASE, new { Code, PhoneNumber,Amount, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<GenericResponse>(response);
        }
    }
}
