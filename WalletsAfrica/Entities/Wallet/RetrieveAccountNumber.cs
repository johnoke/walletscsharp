using System;
using System.Collections.Generic;
using System.Text;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Wallet
{
    public class RetrieveAccountNumberResponse
    {
        public GenericResponse Response { get; set; }
        public List<RetrieveAccountNumberResponseData> Data { get; set; }


    }

    public class RetrieveAccountNumberResponseData
    {
        public int UserId { get; set; }
        public string Bank { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
    }
}
