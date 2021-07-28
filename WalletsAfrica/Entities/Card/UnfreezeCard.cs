using System;
using System.Collections.Generic;
using System.Text;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Card
{
    public class UnFreezeCardResponse
    {
        public GenericResponse Response { get; set; }
        public UnFreezeCardData Data { get; set; }

    }

    public class UnFreezeCardData
    {
        public bool FreezeSuccessful { get; set; }
    }
}
