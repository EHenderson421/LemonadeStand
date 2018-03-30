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
        Player playerOne;
        //Constructor
        public Game()

        {
            rnd = new Random();
            weatherToday = new Day(rnd);
            playerOne = new Player();
        }


        //Member Methods
        public void StartGame()
        {

            playerOne.GetPlayerName();
            User_Interface.DisplayMessage("Welcome To The Game: " + playerOne.name);
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
