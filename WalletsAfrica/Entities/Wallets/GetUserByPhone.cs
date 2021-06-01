using System;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Wallets
{
    public class GetUserByPhoneRequest
    {
        public string PhoneNumber { get; set; }
        public string SecretKey { get; set; }

    }

    public class GetUserByPhoneData
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BVN { get; set; }
        public string DateOfBirth { get; set;  }
        public string DateSignedUp { get; set; }
        public string AccountNo { get; set; }
        public string Bank { get; set; }
        public string AccountName { get; set; }
        public double AvailableBalance { get; set; }
    }


    public class GetUserByPhoneResponse
    {
        public GenericResponse Response { get; set; }
        public GetUserByPhoneData Data { get; set; }
    }
}
