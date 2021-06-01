using System;
namespace WalletsAfrica.Entities.Payout
{
    public class TransferDetailsRequest
    {
        public string SecretKey { get; set; }
        public string TransactionReference { get; set; }
    }

    public class TransferDetailsResponse
    {
        public string Bank { get; set; }
        public string AccountNumber { get; set; }
        public string DateTransferred { get; set; }
        public double Amount { get; set; }
        public string RecipientName { get; set; }
        public string SessionId { get; set; }
        public string ResponseCode { get; set; }
        public string Message { get; set; }
    }


}
