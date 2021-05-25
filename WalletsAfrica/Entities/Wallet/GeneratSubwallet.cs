using System;
using System.Collections.Generic;
using System.Text;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Wallet
{
    public class GeneratSubwalletResponse
    {
        public GenericResponse Response { get; set; }
        public DebitResponseData Data { get; set; }


    }

    public class GeneratSubwalletResponseData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BVN { get; set; }
        public string Password { get; set; }
        public string DateOfBirth { get; set; }
        public string DateSignedup { get; set; }
        public string AccountNo { get; set; }
        public string Bank { get; set; }
        public string AccountName { get; set; }
        public decimal AvailableBalance { get; set; }
    }
}
