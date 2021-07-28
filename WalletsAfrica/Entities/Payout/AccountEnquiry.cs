using System;
using System.Collections.Generic;
using System.Text;

namespace WalletsAfrica.Entities.Payout
{
    public class AccountEnquiryResponse
    {
        public string BankCode { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string ResponseCode { get; set; }
        public string Message { get; set; }
    }
}
