using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WalletsAfrica.Infrastructure;
using WalletsAfrica.Entities.Airtime;
using System.Collections.Generic;

namespace WalletsAfrica.Services
{
    public class AirtimeService
    {
        public AirtimeService(IWalletsAfricaClient client)
        {
            this.client = client;
        }
       

        IWalletsAfricaClient client;
       

        public async Task<AirtimeProvidersResponse> AirtimeProviderAsync()
        {
            var response = await client.Post("/bills/airtime/providers");
            return JsonConvert.DeserializeObject<AirtimeProvidersResponse>(response);
        }

        public async Task<AirtimePurchaseResponse> AirtimePurchaseAsync(string code, double amount, string phoneNumber)
        {
            var response = await client.Post("/bills/airtime/purchase", new AirtimePurchaseRequest { Code = code, Amount = amount, PhoneNumber = phoneNumber, SecretKey = client.SecretKey});
            return JsonConvert.DeserializeObject<AirtimePurchaseResponse>(response);
        }



    }
}
