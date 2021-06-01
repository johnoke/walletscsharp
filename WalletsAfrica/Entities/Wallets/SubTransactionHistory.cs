using System;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Wallets
{
    public class SubTransactionRequest
    {
        public int Skip { get; set; }
        public int Take { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public int TransactionType { get; set; }
        public string PhoneNumber { get; set; }
        public string TransactionPin { get; set; }
        public string SecretKey { get; set; }
        public string Currency { get; set; }

    }

    public class SubTransactionData
    {
        public TransactionModel[] Transactions { get; set; }
    }


    public class TransactionModel
    {
        public double Amount { get; set; }
        public string Currency { get; set; }
        public string Category { get; set; }
        public string Narration { get; set; }
        public string DateTransacted { get; set; }
        public double PreviousBalance { get; set; }
        public double NewBalance { get; set; }
        public string Type { get; set; }

    }

    public class SubTransactionResponse
    {
        public GenericResponse Response { get; set; }
        public SubTransactionData Data { get; set; }
    }
}
