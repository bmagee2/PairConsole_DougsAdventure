using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairConsole_DougsAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // START GAME
            GameActions actions = new GameActions();
            // GAME OBJECTIVES
            actions.MainMenu();
            //actions.GameObjectives();
            actions.StartGame();
            
        }
    }
}
