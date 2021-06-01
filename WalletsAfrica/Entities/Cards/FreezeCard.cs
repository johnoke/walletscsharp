using System;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Cards
{
    public class FreezeCardRequest
    {
        public string CardId { get; set; }
        public string SecretKey { get; set; }
    }

    public class FreezeCardData
    {
        public bool FreezeSuccessful { get; set; }
    }

    public class FreezeCardResponse
    {
        public GenericResponse Response { get; set; }
        public FreezeCardData Data { get; set; }
    }
}
