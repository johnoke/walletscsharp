using System;
namespace WalletsAfrica.Entities.Cards
{
    public class IdentityTypes
    {
        public string ResponseCode { get; set; }
        public IdentityType IdType { get; set; }
    }

    public class IdentityType
    {
        public int BVN { get; set; }
    }
}
