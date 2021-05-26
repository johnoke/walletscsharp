using System;
using System.Collections.Generic;
using System.Text;

namespace WalletsAfrica.Entities.Identity
{
    public class ResolveBvnResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BVN { get; set; }
        public string DateOfBirth { get; set; }
        public string ResponseCode { get; set; }
        public string Message { get; set; }
    }

    public class ResolveBvnDetailsResponse : ResolveBvnResponse
    {
        public string EnrollmentBank { get; set; }
        public string EnrollmentBranch { get; set; }
        public string Gender { get; set; }
        public string LevelOfAccount { get; set; }
        public string LgaOfOrigin { get; set; }
        public string LgaOfResidence { get; set; }
        public string MaritalStatus { get; set; }
        public string Nin { get; set; }
        public string NameOnCard { get; set; }
        public string Nationality { get; set; }
        public string ResidentialAddress { get; set; }
        public string StateOfOrigin { get; set; }
        public string StateOfResidence { get; set; }
        public string Title { get; set; }
        public string WatchListed { get; set; }
        public string Picture { get; set; }
    }
}
