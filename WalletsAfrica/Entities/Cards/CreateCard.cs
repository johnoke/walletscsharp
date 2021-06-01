using System;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Cards
{
    public class CreateCardRequest
    {
        public double Amount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string NameOnCard { get; set; }
        public string Dob { get; set; }
        public string IdNo { get; set; }
        public int IdType { get; set; }
        public string Currency { get; set; }
        public bool IsPhysicalCard { get; set; }
        public string Address { get; set; }
        public int StateId { get; set; }
        public int LocalId { get; set; }
        public string PhoneNumber { get; set; }
        public string SecretKey { get; set; }

    }

    public class CreateCardData
    {
        public string NameOnCard            { get; set; }
        public string ExpiryYear            { get; set; }
        public string BIN                   { get; set; }
        public string CardType              { get; set; }
        public string EncryptedCardNumber   { get; set; }
        public string ExpiryMonth           { get; set; }
        public string ZipCode               { get; set; }
        public string Address               { get; set; }
        public string CardId                { get; set; }
        public string City                  { get; set; }
        public string Last4Digits           { get; set; }
        public string Currency              { get; set; }
        public string Number                { get; set; }
        public string State                 { get; set; }

    }

    public class CreateCardResponse
    {
        public GenericResponse Response { get; set; }
        public CreateCardData Data      { get; set; }
    }
}
