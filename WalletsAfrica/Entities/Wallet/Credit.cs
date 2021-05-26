using System;
using System.Collections.Generic;
using System.Text;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Wallet
{
    public class CreditResponse
    {
        public GenericResponse Response { get; set; }
        public DebitResponseData Data { get; set; }


    }
    public class CreditResponseData
    {
        public decimal AmountCredited { get; set; }
        public decimal RecipientWalletBalance { get; set; }
        public decimal SenderWalletBalance { get; set; }
    }
}
