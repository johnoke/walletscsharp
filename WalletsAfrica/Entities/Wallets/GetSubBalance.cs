using System;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Wallets
{
    public class GetSubBalanceRequest
    {
        public string PhoneNumber { get; set; }
        public string Currency { get; set; }
        public string SecretKey { get; set; }
    }

    public class GetSubBalanceData
    {
        public string WalletBalance { get; set; }
        public string WalletCurrency { get; set; }
    }

    public class GetSubBalanceResponse
    {
        public GenericResponse Response { get; set; }
        public GetSubBalanceData Data { get; set; }
    }
}
