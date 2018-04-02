using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // Member Variables
        public string name;
        public string nameInput;

        //Constructor
        public Player()
        {

        }


        //Member Methods

        public void GetPlayerName()
        {
            User_Interface.DisplayMessage("Enter Your Name: ");
            
            nameInput = User_Interface.GetUserInput();
            name = nameInput.ToUpper();
            

        }
        




    }
}
