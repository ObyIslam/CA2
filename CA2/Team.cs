using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    public class Team : IComparable<Team>
    {
        //properties
        public string Name { get; set; }
        public List<Player> Players { get; set; }


        public int TeamPoints//calculate team points
        {
            get
            {
                int points = 0;

                foreach (Player player in Players)
                {
                    points += player.Points;
                }

                return points;
            }
        }

        public Team()
        {
            Players = new List<Player>();
        }

        public override string ToString()
        {
            return $"{Name} - {TeamPoints}";
        }

        public int CompareTo(Team teams)//sorting 
        {
            return teams.TeamPoints.CompareTo(this.TeamPoints);
        }
        
    }
}
