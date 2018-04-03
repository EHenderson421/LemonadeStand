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
        double todaysCustomer;
        double buyingToday;
        Day weatherToday;
        bool willBuy;
       
        int buyingCustomer;
        //Constructor

        public Customer(Random rnd)
        {
            this.rnd = rnd;
            
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
            
            User_Interface.DisplayMessage("Todays Customer Count" + todaysCustomer);

            return todaysCustomer;
            
        }
        

        public double DetermineWillBuy(double weatherTodayResult)
        {

            buyingCustomer = 0;
            Random rnd = new Random();
            for (int i = 0; i < todaysCustomer; i++)
            {
                int weatherBuy = rnd.Next(0, 100);
                if (weatherTodayResult == 1)
                {
                    if (weatherBuy < 90)
                    {
                        willBuy = true;
                        buyingCustomer++;
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
                        buyingCustomer++;
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
                        buyingCustomer++;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }
                                             
            }

            buyingToday = buyingCustomer++;
            User_Interface.DisplayMessage("Customers That Bought Today" + buyingToday);
            return buyingToday;



        }
    }
}
