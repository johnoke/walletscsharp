using System;
using System.Collections.Generic;
using System.Text;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Card
{
    public class CardDetailsResponse
    {
        public GenericResponse Response { get; set; }
        public CardDetailsData Data { get; set; }

    }

    public class CardDetailsData
    {
        public string Last4Digits { get; set; }
        public string Address { get; set; }
        
        public string ExpiryYear { get; set; }

        public string ExpiryMonth { get; set; }
        public string City { get; set; }
        public string CVV { get; set; }
        public string State { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public string IsActive { get; set; }
        
        public string ZipCode { get; set; }
        
        public string Balance { get; set; }
        
        
    }
}
