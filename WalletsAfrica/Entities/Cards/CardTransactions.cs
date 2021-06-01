using System;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Cards
{
    public class CardTransactionsRequest
    {
        public string CardId { get; set; }
        public string SecretKey { get; set; }
    }

    public class CardTransactionsModel
    {
        public string Description { get; set; }
        public double Amount { get; set; }
        public string TransactionType { get; set; }
        public string DateTime { get; set; }
    }

    public class CardTransactionsData
    {
        public CardTransactionsModel[] Transactions { get; set; }
    }

    public class CardTransactionsResponse
    {
        public GenericResponse Response { get; set; }
        public CardTransactionsData Data { get; set; }
    }
}

