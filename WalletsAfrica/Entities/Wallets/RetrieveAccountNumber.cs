using System;
using WalletsAfrica.Entities.Useful;


namespace WalletsAfrica.Entities.Wallets
{
    public class RetrieveAccountRequest
    {
      public string PhoneNumber { get; set; }

      public string SecretKey { get; set; }

    }

    public class RetrieveAccountData
    {
        public int UserId { get; set; }

        public string Bank { get; set; }

        public string AccountNumber { get; set; }

        public string AccountName { get; set; }

    }


    public class RetrieveAccountResponse
    {
        public GenericResponse Response { get; set; }
        public RetrieveAccountData[] Data { get; set; }
    }
}
