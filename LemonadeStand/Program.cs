using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// data source = DESKTOP-V8K07HH integrated security = SSPI
namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game mygame = new Game();
            mygame.StartGame();
            Console.ReadKey();
        }
    }
}
