using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {

        // Member Variables
        double money;


        //Constructor
        public Wallet()
        {
            money = 20.00;
        }


        //Member Methods

        public double DisplayMoneyInWallet()
        {
            User_Interface.DisplayMessage("You have $" + money + " In your Wallet");
            return money;
        }
        


    }
}
