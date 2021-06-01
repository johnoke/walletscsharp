using System;

namespace WalletsAfrica.Entities.Wallets
{
    public class SetPasswordRequest
    {
       public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string SecretKey { get; set; }
    }

    public class SetPasswordResponse
    {
        public  string ResponseCode { get; set; }
        public string Message { get; set; }
    }
}
