using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // Member Variables
        public int lemon;
        public int ice;
        public int suger;
        public int cup;
        public bool enoughInventory;
        Wallet money;
       
        
        
        //Constructor
        public Inventory()
        {
            money = new Wallet();
        }


        //Member Methods

        public void SubtractInventory()
        {
            lemon = lemon - 1;
            ice = ice - 1;
            suger = suger - 1;
            cup = cup - 1;
        }

        public bool CheckInventory()
        {
            if (lemon >= 1 && ice >= 1 && suger >= 1 && cup >= 1)
                enoughInventory = true;
            else
            {
                enoughInventory = false;

                User_Interface.DisplayMessage("You are out of Lemonade! You will need to restock for tomorrow");
            }

            return enoughInventory;
        }

        public void DisplayInventory()
        {
            User_Interface.DisplayMessage("Inventory: " + lemon + " Lemons, " + ice + " Ice, " + suger + " Suger, " + cup + " Cups, ");

        }


        public void DisplayWalletandInventory()
        {
            User_Interface.DisplayMessage("Inventory: " + lemon + " Lemons, " + ice + " Ice, " + suger + " Suger, " + cup + " Cups, ");
            User_Interface.DisplayMessage("Money: " + money);
        }

    }
}
