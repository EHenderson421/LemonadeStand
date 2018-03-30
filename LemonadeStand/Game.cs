using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        // Member Variables
        Random rnd;
        Day weatherToday;
        double weatherTodayResult;
        
        //Constructor
        public Game()

        {
            rnd = new Random();
            weatherToday = new Day(rnd);
            
        }


        //Member Methods
        public void StartGame()
        {
            weatherToday.TodaysWeather();

            weatherTodayResult = weatherToday.TodaysWeather();

            DisplayWeatherToday(weatherTodayResult);
                
           
        }
        public void DisplayWeatherToday(double weatherTodayResult)
        {
            if (weatherTodayResult == 1)
            {
                User_Interface.DisplayMessage("Todays Weather is 'Sunny and Hot'");
            }
            else if (weatherTodayResult == 2)
            {
                User_Interface.DisplayMessage("Todays Weather is 'Cloudy and Cold'");
            }
            else
            {
                User_Interface.DisplayMessage("Todays Weather is 'Rainy'");
            }

        }


    }
}
