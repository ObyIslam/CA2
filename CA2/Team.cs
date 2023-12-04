using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    public  class Team
    {
        //properties
        public string Name { get; set; }
        public List<Player> Players { get; set; }


        public Team()
        {
            Players = new List<Player>();  
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
