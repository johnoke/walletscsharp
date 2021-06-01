using System;
using System.Threading.Tasks;

namespace WalletsAfrica.Infrastructure
{
    public interface IWalletsAfricaClient
    {
        public string SecretKey { get; set; }
        public string PublicKey { get; set; }
        Task<string> Post(string url = "", object data = null);
       

    }

    public interface IWalletsAfricaClientx
    {
        public string SecretKey { get; set; }
        public string PublicKey { get; set; }
        Task<string> Get(string url = "");
        

    }
}
