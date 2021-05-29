using System;
using System.Collections.Generic;
using System.Text;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Card
{
    public class ChangePinResponse
    {
        public GenericResponse Response { get; set; }
        public ChangePinData Data { get; set; }

    }

    public class ChangePinData
    {
        public bool PinChangeSuccessful { get; set; }
    }
}
