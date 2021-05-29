using System;
using System.Collections.Generic;
using System.Text;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Card
{
    public class CardTransactionResponse
    {
        public GenericResponse Response { get; set; }
        public CardTransactionData Data { get; set; }

    }

    public class TransactionData
    {
        public string Description { get; set; }
        public string TransactionType { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
    }
    public class CardTransactionData
    {
        public List<TransactionData> transactions { get; set; }
        
        
    }
}
