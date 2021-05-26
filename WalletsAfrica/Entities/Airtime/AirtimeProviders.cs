using System;
using System.Collections.Generic;
using System.Text;

namespace WalletsAfrica.Entities.Airtime
{
    public class AirtimeProviderResponse
    {
        public string ResponseCode { get; set; }
        public List<AirtimeProviderData> Providers { get; set; }
    }

    public class AirtimeProviderData 
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

}
