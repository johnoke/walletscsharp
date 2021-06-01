using System;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Airtime
{
    public class AirtimePurchaseRequest
    {
        public string Code { get; set; }
        public double Amount { get; set; }
        public string PhoneNumber { get; set; }
        public string SecretKey { get; set; }
    }

    public class AirtimePurchaseResponse
    {
        public string TransactionReference { get; set; }
        public string ResponseCode { get; set; }
        public string Message { get; set; }
    }
}
