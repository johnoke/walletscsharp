using System;
using System.Collections.Generic;
using System.Text;

namespace WalletsAfrica.Entities.Card
{
    public class Local
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class State
    {
        public string name { get; set; }
        public int id { get; set; }
        public List<Local> locals { get; set; }
    }

    public class State2
    {
        public State state { get; set; }
    }

    public class StateResponse
    {
        public List<State2> States { get; set; }
    }
}
