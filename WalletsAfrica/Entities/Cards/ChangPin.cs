using System;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Cards
{
    public class ChangePinRequest
    {
        public string CardId { get; set; }

        public string SecretKey { get; set; }

        public string Pin { get; set; }
    }

    public class ChangePinData
    {
        public bool PinChangeSuccessful { get; set; }
    }

    public class ChangePinResponse
    {
        public GenericResponse Response { get; set; }
        public ChangePinData Data { get; set; }
    }
}
