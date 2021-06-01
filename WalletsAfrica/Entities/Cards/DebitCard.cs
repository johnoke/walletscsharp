using System;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Cards
{
    public class DebitCardRequest
    {
        public string CardId { get; set; }
        public double Amount { get; set; }
        public string SecretKey { get; set; }
    }

    public class DebitCardData
    {
        public double AmountDebited { get; set; }
    }

    public class DebitCardResponse
    {
        public GenericResponse Response { get; set; }
        public DebitCardData Data { get; set; }
    }
}
