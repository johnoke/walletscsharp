using System;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Self
{
    public class BalanceData
    {
        public string WalletBalance { get; set; }
        public string WalletCurrency { get; set; }
    }
    public class BalanceResponse
    {
        public GenericResponse Response { get; set; }
        public BalanceData Data { get; set; }
    }
}
