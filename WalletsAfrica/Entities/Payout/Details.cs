using System;
using System.Collections.Generic;
using System.Text;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Payout
{
    public class BankTransferDetailsResponse
    {
        public string Bank { get; set; }
        public string AccountNumber { get; set; }
        public string DateTransferred { get; set; }
        public string Amount { get; set; }
        public string RecipientName { get; set; }
        public string SessionId { get; set; }
        public string ResponseCode { get; set; }
        public string Message { get; set; }
    }
}
