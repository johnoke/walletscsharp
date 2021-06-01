using System;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Wallets
{
    public class CreditWalletRequest
    {
        public string TransactionReference { get; set; }
        public double Amount { get; set; }
        public string PhoneNumber { get; set; }
        public string SecretKey { get; set; }
    }

    public class CreditWalletData
    {
        public double AmountCredited { get; set; }
        public double CustomerWalletBalance { get; set; }
        public double BusinessWalletBalance { get; set; }
    }

    public class CreditWalletResponse
    {
        public GenericResponse Response { get; set; }
        public CreditWalletData Data { get; set; }

    }
}
