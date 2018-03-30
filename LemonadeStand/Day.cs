using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        // Member Variables
        Random rnd;
        public int result;


        //Constructor
        public Day(Random rnd)
        {
            this.rnd = rnd;
            
        }


        //Member Methods
        public int TodaysWeather()
        {
            result = rnd.Next(1, 4);
            return result;
        }



    }
}
