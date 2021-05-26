using System;
using System.Collections.Generic;
using System.Text;

namespace WalletsAfrica.Entities.Payout
{
    public class GetBanksResponseData
    {
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankSortCode { get; set; }
        public string PaymentGateway { get; set; }
    }
}
