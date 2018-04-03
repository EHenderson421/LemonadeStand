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
        public double chargePrice;
        public int choiceLemon;
        public int choiceice;
        Inventory inventory;
        Inventory lemon;
        Inventory ice;
        Wallet money;
        Wallet wallet;

        //Constructor
        public Store()
        {
            
            inventory = new Inventory();
            lemon = new Inventory();
            ice = new Inventory();
            money = new Wallet();
            wallet = new Wallet();
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
            else if (chargePrice >= 3.00)
            {
                User_Interface.DisplayMessage("Your price is a little high, and so are you!!!");
                User_Interface.DisplayMessage("Please Try Again");
                InputPrice();
            }

            User_Interface.DisplayMessage("Todays price per cup is " + chargePrice);
            return chargePrice;
        }


        public double BuyLemon()
        {
            User_Interface.DisplayMessage("Your currantly have: " + inventory.lemon + " Lemons ");
            User_Interface.DisplayMessage("Lemons cost $0.10 each. How many Lemons would you like to buy? ");
            choiceLemon = int.Parse(User_Interface.GetUserInput());
            
            if (wallet.money - (choiceLemon * .10) < 0)
            {
                User_Interface.DisplayMessage("Sorry you do not have enought money. Plese try again.");
                BuyLemon();
            }
            else
            {

                inventory.lemon = inventory.lemon + choiceLemon;
                wallet.money = wallet.money - (choiceLemon * .1);
                User_Interface.DisplayMessage("You are now restocked with Lemons");
                User_Interface.DisplayMessage("You have " + inventory.lemon + " Lemons");
                User_Interface.DisplayMessage("you have $" + wallet.money + " left in you wallet.");
                return inventory.lemon;
            }

            return wallet.money;
            
        }


        public double BuyIce()
        {
            User_Interface.DisplayMessage("Your currantly have: " + inventory.ice + " Servings of Ice");
            User_Interface.DisplayMessage("Ice cost $0.15 per serving. How many servings would you like to buy? ");
            choiceLemon = int.Parse(User_Interface.GetUserInput());

            if (wallet.money - (choiceLemon * .15) < 0)
            {
                User_Interface.DisplayMessage("Sorry you do not have enought money. Plese try again.");
                BuyLemon();
            }
            else
            {

                inventory.lemon = inventory.lemon + choiceLemon;
                wallet.money = wallet.money - (choiceLemon * .1);
                User_Interface.DisplayMessage("You are now restocked with Lemons");
                User_Interface.DisplayMessage("You have " + inventory.ice + " Lemons");
                User_Interface.DisplayMessage("you have $" + wallet.money + " left in you wallet.");
                return inventory.lemon;
            }

            return wallet.money;

        }






    }
}
