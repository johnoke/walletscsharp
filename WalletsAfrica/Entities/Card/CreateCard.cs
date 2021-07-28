using System;
using System.Collections.Generic;
using System.Text;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Card
{
    public class CreateCardRespose
    {
        public GenericResponse Response { get; set; }

        public CreateCardData Data { get; set; }
    }

    public class CreateCardData
    {
        public string NameOnCard { get; set; }
        public string ExpiryYear { get; set; }
        public string BIN { get; set; }

        public string CardType { get; set; }
        public string EncryptedCardNumber { get; set; }
        public string ExpiryMonth { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string CardId { get; set; }
        public string City { get; set; }
        public string Last4Digits { get; set; }
        public string Currency { get; set; }
        public string Number { get; set; }
        public string State { get; set; }
    }
}
