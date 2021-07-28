using System;
using System.Collections.Generic;
using System.Text;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Card
{
    public class FreezeCardResponse
    {
        public GenericResponse Response { get; set; }
        public FreezeCardData Data { get; set; }

    }

    public class FreezeCardData
    {
        public bool FreezeSuccessful { get; set; }
    }
}
