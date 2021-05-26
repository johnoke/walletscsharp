using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WalletsAfrica.Constants;
using WalletsAfrica.Entities.Identity;
using WalletsAfrica.Infrastructure;

namespace WalletsAfrica.Services
{
    public class IdentityService
    {
        private readonly IWalletsAfricaClient client;

        public IdentityService(IWalletsAfricaClient client)
        {
            this.client = client;
        }

        public async Task<ResolveBvnResponse> ResolveBvn(string Bvn)
        {
            var response = await client.Post(Endpoints.RESOLVEBVN, new { Bvn, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<ResolveBvnResponse>(response);
        }

        public async Task<ResolveBvnDetailsResponse> ResolveBvnWithDetails(string Bvn)
        {
            var response = await client.Post(Endpoints.RESOLVEBVNWITHDETAILS, new { Bvn, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<ResolveBvnDetailsResponse>(response);
        }
    }
}
