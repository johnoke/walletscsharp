using System;
using System.Collections.Generic;
using System.Text;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Wallet
{
    public class DebitResponse
    {
        public GenericResponse Response { get; set; }
        public DebitResponseData Data { get; set; }       


    }
    public class DebitResponseData
    {
        public decimal AmountCredited { get; set; }
        public decimal CustomerWalletBalance { get; set; }
        public decimal DeveloperWalletBalance { get; set; }
    }

}
