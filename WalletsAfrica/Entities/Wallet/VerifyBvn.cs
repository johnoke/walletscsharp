using System;
using System.Collections.Generic;
using System.Text;

namespace WalletsAfrica.Entities.Wallet
{
    class VerifyBvn
    {
    }

    public class VerifyBvnResponse
    {
        public string Message { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal WalletBalance { get; set; }
        public string BVN { get; set; }
        public bool HasBVN { get; set; }
        public bool PassCodeSet { get; set; }
        public string DisplayPicture { get; set; }
        public string Username { get; set; }
        public int UserProgress { get; set; }
        public int AccountType { get; set; }
    }

}
