using System;
namespace WalletsAfrica.Entities.Cards
{
    



    public class StateModel
    {
        public string name { get; set; }
        public int id { get; set; }
        public Locals[] locals { get; set; }
    }

    public class Locals
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class StateData
    {
        public StateModel state { get; set; }
    }

    public class NigerianStates
    {
        public StateData[] States { get; set; }
    }
}
