using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    public class Player
    {
        public string Name { get; set; }
        public string ResultRecord { get; set; }
        public int Points
        {
            get
            {
                int points = 0;


                if (!string.IsNullOrEmpty(ResultRecord) && ResultRecord.Length >= 5)
                {
                    string lastFiveResults = ResultRecord.Substring(ResultRecord.Length - 5);
                    foreach (char result in lastFiveResults) 
                    { 
                        if (result == 'W')
                        {
                            points += 3; 
                        }
                        else if (result == 'D')
                        {
                            points += 1; 
                        }
                    }
                }
                return points;
            }
        }

        //public void StarRatings()
        //{
        //    string points0 = @"../../../0points";
        //    string points1to5 = @"../../../1-5points";
        //    string points6to10 = @"../../../6-10points";
        //    string points11to15 = "../../../11-15points";



        //}


        public override string ToString() { return $"{Name} - Result Record: {ResultRecord} - {Points}"; }
    }
}



