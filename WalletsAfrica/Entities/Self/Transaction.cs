using System;
using System.Collections.Generic;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Self
{
    public class Transaction
    {
        public string Currency { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public string Narration { get; set; }
        public string DateTransacted { get; set; }
        public decimal PreviousBalance { get; set; }
        public decimal NewBalance { get; set; }
        public string Type { get; set; }
    }
    public class TransactionResponse
    {
        public GenericResponse Response { get; set; }
        public TransactionData Data { get; set; }
    }
    public class TransactionData
    {
        public List<Transaction> Transactions { get; set; }
    }
}

