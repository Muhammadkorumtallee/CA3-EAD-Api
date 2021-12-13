using System.Collections.Generic;

namespace Basketball_CA3_EAD.Classes
{
    public class Team
    {
        public int id { get; set; }
        public string city { get; set; }
        public string division { get; set; }
        public string full_name { get; set; }
        public string name { get; set; }
        public List<Team> team { get; set; }
    }

    public class Player
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public int? height_feet { get; set; }
        public int? height_inches { get; set; }
        public string last_name { get; set; }
        public string position { get; set; }
        public Team team { get; set; }
        public int? weight_pounds { get; set; }
        public List<Player> data { get; set; }
    }

    public class Datum
    {
        public int games_played { get; set; }
        public int player_id { get; set; }
        public int season { get; set; }
        public string min { get; set; }
        public double fgm { get; set; }
        public double fga { get; set; }
        public double fg3m { get; set; }
        public double fg3a { get; set; }
        public double ftm { get; set; }
        public double fta { get; set; }
        public double oreb { get; set; }
        public double dreb { get; set; }
        public double reb { get; set; }
        public double ast { get; set; }
        public double stl { get; set; }
        public double blk { get; set; }
        public double turnover { get; set; }
        public double pf { get; set; }
        public double pts { get; set; }
        public double fg_pct { get; set; }
        public double fg3_pct { get; set; }
        public double ft_pct { get; set; }
    }

    public class Root
    {
        public List<Datum> data { get; set; }
    }
}
