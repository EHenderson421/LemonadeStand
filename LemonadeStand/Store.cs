using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        // Member Variables
        double chargePrice;


        //Constructor
        public Store()
        {

        }


        //Member Methods
        public double InputPrice()
        {
            User_Interface.DisplayMessage("How much would you like to charge for a cup of lemonade? example");
            User_Interface.DisplayMessage("example 50 cents would be .50, 1 dollor would be 1.00");
            chargePrice = double.Parse(User_Interface.GetUserInput());
            if (chargePrice <= 0.009)
            {
                User_Interface.DisplayMessage("Please Try Again");
                InputPrice();
            }
            else if (chargePrice >= 2.00)
            {
                User_Interface.DisplayMessage("Your price is a little high, and so are you!!!");
                User_Interface.DisplayMessage("Please Try Again");
                InputPrice();
            }

            User_Interface.DisplayMessage("Todays price per cup is " + chargePrice);
            return chargePrice;
        }



    }
}
