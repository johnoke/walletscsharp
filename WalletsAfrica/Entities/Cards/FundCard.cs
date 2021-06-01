using System;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Cards
{
    public class FundCardRequest
    {
        public string CardId { get; set; }
        public double Amount { get; set; }
        public string SecretKey { get; set; }
    }

    public class FundCardData
    {
        public double AmountCredited { get; set; }
    }


    public class FundCardResponse
    {
        public GenericResponse Response { get; set; }
        public FundCardData Data { get; set; }
    }
}
