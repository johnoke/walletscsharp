using System;
using System.Net;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WalletsAfrica.Infrastructure
{
    public class WalletsAfricaClient : IWalletsAfricaClient
    {
        public WalletsAfricaClient(string secretKey = null, string publicKey = null, bool isLive = false)
        {
            this.SecretKey = secretKey;
            this.PublicKey = publicKey;
            this.BaseUrl = isLive ? "https://api.wallets.africa" : "https://sandbox.wallets.africa";
        }
        public string SecretKey { get; set; }
        public string PublicKey { get; set; }
        public string BaseUrl { get; set; }
        public async Task<string> Post(string url = "", object data = null)
        {
            var client = new HttpClient();
            url = this.BaseUrl + url;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol =  SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {this.PublicKey}");
            client.Timeout = TimeSpan.FromMinutes(5);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response;
            if (data != null)
            {
                response = await client.PostAsJsonAsync(url, data);
            }
            else
            {
                response = await client.PostAsJsonAsync(url, new { });
            }
            var httpStatusCode = (int)response.StatusCode;
            if (httpStatusCode == 200 || httpStatusCode == 201 || httpStatusCode == 202)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> Get(string url = "")
        {
            var clientx = new HttpClient();
            url = this.BaseUrl + url;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            clientx.DefaultRequestHeaders.Add("Authorization", $"Bearer {this.PublicKey}");
            clientx.Timeout = TimeSpan.FromMinutes(5);
            clientx.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response;
            if (url != null)
            {
                response = await clientx.GetAsync(url);
            }
            else
            {
                response = await clientx.GetAsync(url);
            }
            var httpStatusCode = (int)response.StatusCode;
            if (httpStatusCode == 200 || httpStatusCode == 201 || httpStatusCode == 202)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return await response.Content.ReadAsStringAsync();
        }

    }

    public class WalletsAfricaClientx : IWalletsAfricaClientx
    {
        public WalletsAfricaClientx(string secretKey = null, string publicKey = null, bool isLive = false)
        {
            this.SecretKey = secretKey;
            this.PublicKey = publicKey;
            this.BaseUrl = isLive ? "https://api.wallets.africa" : "https://sandbox.wallets.africa";
        }
        public string SecretKey { get; set; }
        public string PublicKey { get; set; }
        public string BaseUrl { get; set; }

        public async Task<string> Get(string url = "")
        {
            var clientx = new HttpClient();
            url = this.BaseUrl + url;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            clientx.DefaultRequestHeaders.Add("Authorization", $"Bearer {this.PublicKey}");
            clientx.Timeout = TimeSpan.FromMinutes(5);
            clientx.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response;
            if (url != null)
            {
                response = await clientx.GetAsync(url);
            }
            else
            {
                response = await clientx.GetAsync(url);
            }
            var httpStatusCode = (int)response.StatusCode;
            if (httpStatusCode == 200 || httpStatusCode == 201 || httpStatusCode == 202)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return await response.Content.ReadAsStringAsync();
        }

    }
}
