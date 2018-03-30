using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        // Member Variables
        Random rnd;
        public int result;
        

        //Constructor
        public Weather(Random rnd)
        {
            this.rnd = rnd;
        }


        //Member Methods


        //public override void WeatherForcast()
        public int WeatherForcast()
        {
            result = rnd.Next(1, 4);
            return result;
        }



    }
}
