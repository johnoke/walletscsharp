using System;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Wallets
{
   
        public class DebitWalletRequest
        {
            public string TransactionReference { get; set; }
            public double Amount { get; set; }
            public string PhoneNumber { get; set; }
            public string SecretKey { get; set; }
        }

        public class DebitWalletData
        {
            public double AmountCredited { get; set; }
            public double CustomerWalletBalance { get; set; }
            public double BusinessWalletBalance { get; set; }
        }

        public class DebitWalletResponse
        {
            public GenericResponse Response { get; set; }
            public DebitWalletData Data { get; set; }

        }
}
