using System;
using System.Collections.Generic;
using System.Text;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Card
{
    public class DebitCardResponse
    {
        public GenericResponse Response { get; set; }
        public DebitCardData Data { get; set; }

    }

    public class DebitCardData
    {
        public decimal AmountDebited { get; set; }
    }
}
