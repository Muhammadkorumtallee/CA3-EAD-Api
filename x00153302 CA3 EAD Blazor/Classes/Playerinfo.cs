using System.Collections.Generic;

namespace Basketball_CA3_EAD.Classes
{
    public class Team
    {
        public string city { get; set; }
        public string division { get; set; }
        public string full_name { get; set; }
        public string name { get; set; }
    }

    public class Player
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string position { get; set; }
        public Team team { get; set; }
        public List<Player> data { get; set; }
    }
}
