using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    public  class Player
    {
        //properties
        public string Name { get; set; }
        public string ResultRecord { get; set; }


        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
