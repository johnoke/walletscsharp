using System;
using WalletsAfrica.Entities.Useful;
namespace WalletsAfrica.Entities.Self
{
    public class GetWalletsRequest
    {
        public string SecretKey { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
    }

    public class GetWalletsData
    {
        public string Username { get; set; }
        public string AccountNumber { get; set; }
        public string BVN { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string DateCreated { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }

  


    public class GetWalletsResponse
    {
        public GenericResponse Response { get; set; }
        public GetWalletsData[] Data { get; set; }
    }
}
