using System;
using System.Collections.Generic;
using System.Text;
using WalletsAfrica.Entities.Useful;

namespace WalletsAfrica.Entities.Card
{
    public class FundCardResponse
    {
        public GenericResponse Response { get; set; }
        public FundCardData Data { get; set; }

    }

    public class FundCardData
    {
        public decimal AmountCredited { get; set; }
    }
}
