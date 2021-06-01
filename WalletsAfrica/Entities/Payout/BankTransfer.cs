using System;
namespace WalletsAfrica.Entities.Payout
{
    public class BankTransferRequest
    {
        public string SecretKey { get; set; }
        public string BankCode { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string TransactionReference { get; set; }
        public double Amount { get; set; }
        public string Narration { get; set; }

    }

    public class BankTransferResponse
    {
        public string ResponseCode { get; set; }
        public string Message { get; set; }
    }


}
