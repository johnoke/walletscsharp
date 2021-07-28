using System;
using System.Collections.Generic;
using System.Text;

namespace WalletsAfrica.Entities.Card
{
    public class IdTypeResponse
    {
        public string ResponseCode { get; set; }

        public IdTypeData IdType { get; set; }
    }

    public class IdTypeData
    {
        public string BVN { get; set; }
    }
}
