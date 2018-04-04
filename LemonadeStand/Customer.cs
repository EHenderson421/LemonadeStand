using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        // Member Variables
        Random rnd;
        Game weatherTodayResult;
        public double todaysCustomer;
        public double buyingTodayWeather;
        Day weatherToday;
        public bool willBuy;
        public double buyingCustomer;
        public double buyingCustomerWeather;
        public double buyingCustomerPrice;
        Store chargePrice;
        Game pricePerCup;
        Game buyTodayWeatherPrice;
        //Constructor

        public Customer(Random rnd)
        {
            this.rnd = rnd;
            chargePrice = new Store();
           // pricePerCup = new Game();
        }


        //Member Methods

        public double CustomersToday(double weatherTodayResult)
        {
           
            Random rnd = new Random();
            if (weatherTodayResult == 1)
            {
                todaysCustomer = rnd.Next(50, 75);
            }
            else if (weatherTodayResult == 2)
            {
                todaysCustomer = rnd.Next(30, 60);
            }
            else if (weatherTodayResult == 3)
            {
                todaysCustomer = rnd.Next(20, 40);
            }
            
            User_Interface.DisplayMessage("Todays Customer Count " + todaysCustomer);

            return todaysCustomer;
            
        }
        

        public double DetermineWillBuyWeather(double weatherTodayResult)
        {

            buyingCustomerWeather = 0;
            Random rnd = new Random();
            for (int i = 0; i < todaysCustomer; i++)
            {
                int weatherBuy = rnd.Next(0, 100);
                if (weatherTodayResult == 1)
                {
                    if (weatherBuy < 90)
                    {
                        willBuy = true;
                        buyingCustomerWeather++;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }

                if (weatherTodayResult == 2)
                {
                    if (weatherBuy < 70)
                    {
                        willBuy = true;
                        buyingCustomerWeather++;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }

                if (weatherTodayResult == 3)
                {
                    if (weatherBuy < 50)
                    {
                        willBuy = true;
                        buyingCustomerWeather++;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }
                                             
            }

            buyingTodayWeather = buyingCustomerWeather++;
            User_Interface.DisplayMessage("Customers That walked up Today " + buyingTodayWeather);
            return buyingTodayWeather;
            


        }


        public double DetermineWillBuyPrice(double chargePrice)
        {

            buyingCustomerPrice = 0;
            Random rnd = new Random();
            for (int i = 0; i < buyingTodayWeather; i++)
            {
                int buyPrice = rnd.Next(0, 100);
                if (chargePrice > 0 && chargePrice <= .1)
                {
                    if (buyPrice < 100)
                    {
                        willBuy = true;
                        buyingCustomerPrice++;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }

                if (chargePrice > .1 && chargePrice <= .5)
                {
                    if (buyPrice < 90)
                    {
                        willBuy = true;
                        buyingCustomerPrice++;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }

                if (chargePrice > .5 && chargePrice <= .75)
                {
                    if (buyPrice < 80)
                    {
                        willBuy = true;
                        buyingCustomerPrice++;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }

                if (chargePrice > .75 && chargePrice <= 1)
                {
                    if (buyPrice < 70)
                    {
                        willBuy = true;
                        buyingCustomerPrice++;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }

                if (chargePrice > 1 && chargePrice <= 1.25)
                {
                    if (buyPrice < 60)
                    {
                        willBuy = true;
                        buyingCustomerPrice++;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }

                if (chargePrice > 1.25 && chargePrice <= 1.5)
                {
                    if (buyPrice < 50)
                    {
                        willBuy = true;
                        buyingCustomerPrice++;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }
            

                if (chargePrice > 1.5 && chargePrice <= 2)
                {
                    if (buyPrice < 40)
                    {
                        willBuy = true;
                        buyingCustomerPrice++;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }

                if (chargePrice > 2 && chargePrice <= 2.5)
                {
                    if (buyPrice < 30)
                    {
                        willBuy = true;
                        buyingCustomerPrice++;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }

                if (chargePrice > 2.5 && chargePrice <= 3)
                {
                    if (buyPrice < 20)
                    {
                        willBuy = true;
                        buyingCustomerPrice++;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }
            }

        buyingCustomer = buyingCustomerPrice++;
            User_Interface.DisplayMessage("Customers That Bought Today " + buyingCustomer);
            return buyingCustomer;


        }
    }
}
