﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {

        // Member Variables
        public double money;


        //Constructor
        public Wallet()
        {
            money = 20.00;
        }


        //Member Methods

        public double DisplayMoneyInWallet()
        {
            User_Interface.DisplayMessage("You have $" + money + " Left in your Wallet");
           return money;
        }
        


    }
}
