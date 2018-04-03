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
        public double weatherTodayResult;
        Player playerOne;
        Customer todaysCustomer;
        Customer buyingToday;
        public double buyingCustomersToday;
        public double numberOfCustomersToday;
        Store chargePrice;
        public double pricePerCup;
        Wallet money;
        public double playerMoney;
        Store buySupplies;
        public double getSupplies;
       
        
        //Constructor
        public Game()

        {
            rnd = new Random();
            weatherToday = new Day(rnd);
            playerOne = new Player();
            todaysCustomer = new Customer(rnd);
            chargePrice = new Store();
            money = new Wallet();
            buySupplies = new Store();

        }


        //Member Methods
        public void StartGame()
        {

            playerOne.GetPlayerName();
            User_Interface.DisplayMessage("Welcome To The Game: " + playerOne.name);
            weatherTodayResult = weatherToday.TodaysWeather();
            DisplayWeatherToday(weatherTodayResult);
            playerMoney = money.DisplayMoneyInWallet();
            getSupplies = buySupplies.BuyLemon();
            getSupplies = buySupplies.BuyIce();
            getSupplies = buySupplies.BuySuger();
            getSupplies = buySupplies.BuyCup();
            pricePerCup = chargePrice.InputPrice();
            numberOfCustomersToday = todaysCustomer.CustomersToday(weatherTodayResult);
            buyingCustomersToday = todaysCustomer.DetermineWillBuy(weatherTodayResult);
            
            


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
