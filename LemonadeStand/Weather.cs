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
        public string result;
        public string weatherForcast;

        //Constructor
        public Weather(Random rnd)
        {
            this.rnd = rnd;
        }


        //Member Methods
       

        //public override void WeatherForcast()
        //{
        //    Random random = new Random();
        //    possibleMove = choice[random.Next(0, choice.Count)];
        //    Console.WriteLine("\n" + name + " Has Decided To Throw: " + possibleMove);
        //}




    }
}
