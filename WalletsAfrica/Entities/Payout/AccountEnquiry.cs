using System;
namespace WalletsAfrica.Entities.Payout
{
    public class AccountEnquiryRequest
    {
        public string AccountNumber { get; set; }
        public string BankCode { get; set; }
        public string SecretKey { get; set; }
    }

    public class AccountEnquiryResponse
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string Bankode { get; set; }
        public string ResponseCode { get; set; }
        public string Message { get; set; }

    }
}
