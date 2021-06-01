using System;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Cards
{
    public class CardDetailsRequest
    {
        public string CardId { get; set; }
        public string SecretKey { get; set; }
    }

    public class CardDetailsData
    {
        public string Last4Digits { get; set; }
        public string Address { get; set; }
        public string CVV { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public bool   IsActive { get; set; }
        public string ZipCode { get; set; }
        public double Balance { get; set; }
        
    }

    public class CardDetailsResponse
    {
        public GenericResponse Response { get; set; }
        public CardDetailsData Data { get; set; }
    }
}
