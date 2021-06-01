using System;
namespace WalletsAfrica.Entities.Wallets
{
    public class SetPinRequest
    {
        public string PhoneNumber { get; set; }
        public string TransactionPin { get; set; }
        public string SecretKey { get; set; }
    }

    public class SetPinResponse
    {
        public string ResponseCode { get; set; }
        public string Message { get; set; }
    }
}
