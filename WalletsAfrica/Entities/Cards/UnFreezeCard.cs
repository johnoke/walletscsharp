using System;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Cards
{
    public class UnFreezeCardRequest
    {
        public string CardId { get; set; }
        public string SecretKey { get; set; }
    }

    public class UnFreezeCardData
    {
        public bool FreezeSuccessful { get; set; }
    }

    public class UnFreezeCardResponse
    {
        public GenericResponse Response { get; set; }
        public FreezeCardData Data { get; set; }
    }
}
