using System;
using WalletsAfrica.Entities.Useful;
namespace WalletsAfrica.Entities.Wallets
{
    public class GenerateWalletRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string SecretKey { get; set; }
        public string DateOfBirth { get; set; }
        public string Currency { get; set; }
    }

    public class GenerateWalletData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BVN { get; set; }
        public string Password { get; set; }
        public string DateOfBirth { get; set; }
        public string DateSignedUp { get; set; }
        public string AccountNo { get; set; }
        public string Bank { get; set; }
        public string AccountName { get; set; }
        public double AvailableBalance { get; set; }
    }

    public class GenerateWalletResponse
    {
        public GenericResponse Response { get; set; }
        public GenerateWalletData Data { get; set; }
    }
}
