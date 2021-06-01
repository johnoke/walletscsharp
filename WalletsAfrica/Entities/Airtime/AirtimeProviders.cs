using System;
namespace WalletsAfrica.Entities.Airtime
{

    public class AirtimeProviders
    {

        public string Code { get; set; }
        public string Name { get; set; }
        
    }
    public class AirtimeProvidersResponse
    {
        public string ResponseCode { get; set; }
        public AirtimeProviders[] Data {get; set;}
        
    }
}
