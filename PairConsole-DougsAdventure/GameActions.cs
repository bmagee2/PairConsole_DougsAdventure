using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairConsole_DougsAdventure
{
    public class GameActions
    {
        public void MainMenu()
        {

            // WELCOME 

            // GAME INFO
            GameObjectives();
            Console.WriteLine();
        }

        public void GameObjectives()
        {
            Console.WriteLine("Welcome to Doug's Great Farm Adventure!");
            Console.WriteLine();
            Console.WriteLine("\n" +
               "                             0        0      \n" +
               "                             |        |       \n" +
               "                          ___|________|___\n" +
               "      YOU ARE DOUG.      |                |\n" +
               "      DOUG'S AN ALIEN.   |  ----    ----  | \n" +
               "                         |   (O)     (O)  |\n" +
               "                         |                |   __          \n" +
               "                         |     _______    |  |__|     \n" +
               "                         |    (^_^_^_^)   |  / /      \n" +
               "                         |                | / /       \n" +
               "                         |________________|/ /         ");
            Console.WriteLine();
            Console.WriteLine("Follow instructions on the screen to follow Doug through his adventure.");
        }

        // PLAYER OPTION 1
        public void OptionOne()
        {
            Console.Clear();
        
            Console.WriteLine();
            Console.WriteLine("You have just crashed landed in a rural farm on a planet you were monitoring called Earth. Sparks fly from the console of your saucer, and smoke billows from the exhaust. You open up your hatch, and fall out onto a patch of what these earthlings call grass. You look at your ship to see that it has crashed into a red wooden structure, turning it to splinters (No animals were harmed- they were in the field). Your ship is totaled and would take forever to replace all the parts.\n");
            Console.WriteLine("An earthling approaches with a long two barreled weapon, you believe these type of earthlings call themselves ‘Far- meres’ and points it at your chest!\n" +
            " \n" +    
                " 'You’ve wrecked my barn! Now I don’t know where you’re from! But that doesn’t give you the right to go destroying other people’s property! You’re going to have to pay for me to get this fixed!'The Farmer yells. ");
            Console.WriteLine();
            Console.WriteLine("You look at the Far-mere, perplexed. You have a death ray gun, you could just disintegrate him and be on your way. Or you do have a little bit of a rare metal you mined from Mars that would easily pay for his primitive ‘barn’, and you could continue your quest to fix your ship....");
            Console.WriteLine();
            Console.WriteLine("Choose an option:\n" +
                "1. Give valuable metal to farmer.\n" +
                "2. Shoot farmer with deathray gun.");

            string choiceOne = Console.ReadLine();

            Console.WriteLine();
            switch (choiceOne)
            {
                case "1":
                    GiveMetal();
                    OptionTwo();
                    break;
                case "2":
                    ShootFarmer();
                    Console.WriteLine();
                    // GAMEOVER METHOD
                    GameOver();
                    break;
                default:
                    Console.WriteLine("not an option");
                    OptionOne();
                    break;
            }
        }


        public void OptionTwo()
        {
            Console.WriteLine("Choose an option:\n" +
                "1. Offer to work on farm to pay for barn.\n" +
                "2. Shoot farmer with deathray gun.");

            Console.WriteLine();

            string choiceOne = Console.ReadLine();
            switch (choiceOne)
            {
                case "1":
                    OfferToWork();
                    OptionThree();
                    break;
                case "2":
                    ShootFarmer();
                    Console.WriteLine();
                    // GAMEOVER METHOD
                    GameOver();
                    break;
                default:
                    Console.WriteLine("not an option");
                    OptionTwo();
                    break;
            }
        }

        public void OptionThree()
        {
            Console.WriteLine("Choose an option:\n" +
                "1. Examine goat.\n" +
                "2. Pick up shovel.");

            Console.WriteLine();

            string choiceOne = Console.ReadLine();
            switch (choiceOne)
            {
                case "1":
                    ExamineGoat();
                    Console.WriteLine();
                    OptionThreeJR();
                    break;
                case "2":
                    PickUpShovel();
                    Console.WriteLine();
                    GoatTransforms();
                    Console.WriteLine();
                    OptionFour();
                    break;
                default:
                    Console.WriteLine("not an option");
                    OptionThree();
                    break;
            }
        }
        public void OptionThreeJR()
        {
            Console.WriteLine("Choose an option:\n" +
               "1. Pick up shovel.");

            Console.WriteLine();

            string choiceOne = Console.ReadLine();
            switch (choiceOne)
            {
                case "1":
                    PickUpShovel();
                    Console.WriteLine();
                    GoatTransforms();
                    Console.WriteLine();
                    OptionFour();
                    break;
                default:
                    Console.WriteLine("not an option");
                    OptionThreeJR();
                    break;
            }
        }
        public void OptionFour()
        {
            Console.WriteLine("Choose an option:\n" +
                "1. Attack that goat!\n" +
                "2. Offer the goat the shovel.");

            Console.WriteLine();

            string choiceOne = Console.ReadLine();
            switch (choiceOne)
            {
                case "1":
                    AttackGoat();
                    Console.WriteLine();
                    // GAMEOVER METHOD
                    GameOver();
                    break;
                case "2":
                    OfferGoatShovel();
                    Console.WriteLine();
                    OptionNameGoat();
                    break;
                default:
                    Console.WriteLine("not an option");
                    OptionFour();
                    break;
            }
        }

        private string _goatName;

        public void OptionNameGoat()
        {
            Console.Write("Now that you have earned the mutant goat's trust you should give it a name!\n" +
                "Goat's new name: ");
            Console.WriteLine();
            string goatName = Console.ReadLine();
            _goatName = goatName;
            goatName = " " + goatName;
            OptionFive();
        }


       
        public void OptionFive()
        {

            Console.WriteLine($"Choose an option:\n" +
               "1.Climb on " + _goatName + "!\n" +
               "2.Find another tool and continue working.") ;

            Console.WriteLine();

            string choiceOne = Console.ReadLine();
            switch (choiceOne)
            {
                case "1":
                    ClimbOnGoat();
                    // GAMEOVER METHOD need you win method
                    YouWin();
                    break;
                case "2":
                    FindAnotherTool();
                    OptionSix();
                    break;
                default:
                    Console.WriteLine("not an option");
                    OptionFive();
                    break;
            }
        }

        public void OptionFiveJr()
        {
            Console.WriteLine("Choose an option:\n" +
               "1.Climb on " + _goatName + "!");

            Console.WriteLine();

            string choiceOne = Console.ReadLine();
            switch (choiceOne)
            { //Maybe add funny death option.
                case "1":
                    ClimbOnGoat();
                    // GAMEOVER METHOD need you win method
                    YouWin();
                    break;
                //case "2":
                //    actions.FindAnotherTool();
                //    // NEW OPTION
                //    break;
                default:
                    Console.WriteLine("not an option");
                    OptionFiveJr();
                    break;
            }

        }
        public void OptionSix()
        {
            Console.WriteLine("After many hours of work, and allowing the mutant goat to eat your spaceship, the farmer returns to see that the pen is cleaner than he's ever seen. He offers you a permanant job as his farm hand.");
            Console.WriteLine();
            Console.WriteLine("Choose an option:\n" +
               "1.Accept\n" +
               "2.Decline");

            Console.WriteLine();

            string choiceOne = Console.ReadLine();
            switch (choiceOne)
            {
                case "1":
                    AcceptOffer();
               
                    YouWin();
                    break;
                case "2":
                    DeclineOffer();
                    OptionFiveJr();
                    // NEW OPTION
                    break;
                default:
                    Console.WriteLine("not an option");
                    OptionSix();
                    break;
            }
        }
        public void GameOver()
        {
            Console.WriteLine("GAME OVER.");
            //Console.Clear();
            PlayAgain();
        }

        public void YouWin()
        {
            Console.WriteLine("The end?");
            //Console.Clear();
            PlayAgain();
        }

        public void StartGame()
        {
            Console.WriteLine("Ready to play?:\n" +
                "1. Yes!\n" +
                "2. No.");

            string choiceOne = Console.ReadLine();
            switch (choiceOne)
            {
                case "1":
                    OptionOne();
                    break;
                case "2":
                    Console.WriteLine("C'mon, give it a try! You'll love Doug.");
                    ExitGame();
                    break;
                default: //fix defaults to start encounter over
                    Console.WriteLine("Doug shoots at you with a deathray gun for not picking a valid option. Try again.");
                   StartGame();
                   
                    break;
            }
        }

        public void ExitGame()
        {
            Console.WriteLine("Ready to play?:\n" +
                "1. Ok, fine.\n" +
                "2. NO!");


            string choiceOne = Console.ReadLine();
            switch (choiceOne)
            {
                case "1":
                    Console.Clear();
                    StartGame();
                    break;
                case "2":
                    // DOUG SHOOTS YOU WITH DEATHRAY -- EXITS CONSOLE
                    //Console.WriteLine("Fine! But Doug shoots you with a deathray gun.");
                    //_isRunning = false;
                    break;
                default: //fix defaults to start encounter over
                    Console.WriteLine("Doug shoots at you with a deathray gun for not picking a valid option. Try again.");
                    StartGame();
                    break;
            }
        }

        public void PlayAgain()
        {
            Console.WriteLine("Ready to play again?:\n" +
                "1. Yes!\n" +
                "2. No.");


            string choiceOne = Console.ReadLine();
            switch (choiceOne)
            {
                case "1":
                    Console.Clear();
                    MainMenu();
                    StartGame();
                    break;
                case "2":
                    Console.WriteLine("C'mon, give it a try!");
                    break;
                default:
                    Console.WriteLine("not an option");
                    PlayAgain();
                    break;
            }
        }


        public void GiveMetal()
        {
            Console.WriteLine("You turn back to see your ship and there is a strange hooved creature standing on top of your ship, you remember this animal, as it is one of your favorites. Oh, how amusing they are! This is a goat! Although this goat was already chewing on something, you see a glint of gold, the same gold as the rare metal from Mars! The goat swallows, and belches loudly. You sigh as you turn back to the Far-mere.");
            Console.WriteLine();
        }

        public void ShootFarmer()
        {
            Console.WriteLine("Your weapon malfunctions and the farmer shoots you with his double barreled weapon. Your blue guts splatter everywhere and you are dead.");
            Console.WriteLine();
        }

        public void OfferToWork()
        {
            Console.WriteLine("The Far-mere thinks and nods accepting your offer to work for him in order to pay off the debt for the barn.'You can start by picking the pins, there’s a shovel in the barn you can use!'\n" +
                " \n" +
                " The far-mere turns back to his house as you make your way to the pens.\n" +
                " \n " +
                "Inside the pen is horrid smell filled with the waste of these carbon-based creatures. You see the shovel, and you also see the goat that ate your metal, munching on a can it found.");
            Console.WriteLine();
        }

        public void ExamineGoat()
        {
            Console.WriteLine("As you begin to examine the goat, to see if there might be a way to retrieve the metal. You pull on its tail. The goat bleats angrily and kicks you in the head, knocking you into to a large pile of carbon waste.You stand up and wipe away the foul smelling substance from your eyes.");
            Console.WriteLine();
        }

        public void PickUpShovel()
        {
            Console.WriteLine("Get to work!");
        }

        public void GoatTransforms()
        {
            Console.WriteLine("As you pick up the shovel to begin working, the goat begins to shake uncontrollably. It grows double in size! Its muscle enhance, and its hooves turn into the same color as the precious metal that it had eaten! Before you stands a Mutant Goat, it bleats at you.");
            Console.WriteLine();
        }

        public void AttackGoat()
        {
            Console.WriteLine("You swing the shovel at the goat, but with its enhanced Mutant Goat reactions, the goat bites the end of the shovel off and swallows it whole. It bleats angrily at you as it lifts its large golden hoof and squashes you with a powerful stomp. Your blue guts explode everywhere. You are dead.");
            Console.WriteLine();
        }

        public void OfferGoatShovel()
        {
            Console.WriteLine("You hold up the shovel to the goat, in a non-threatening offering. The goat looks at the shovel curiously, sniffs it and begins to munch on the end. It bleats happily at you and nuzzles your large green head. You pat the goat lovingly.");
            Console.WriteLine();
        }

        public void ClimbOnGoat()
        {
            Console.WriteLine("You hop on " + _goatName + " and without another word, the wind blows past your antennas, as you ride offinto the sunset together as mutant goat and alien, with every possibility now at your unstoppable grasps.");
            Console.WriteLine();
        }

        public void FindAnotherTool()
        {
            Console.WriteLine("You grab another nearby shovel, and get to work on cleaning the pen. Several hours pass and come sundown, you are tired, your muscles are sore from a long day’s work. The far-mere returns to look at your handy work.\n" +
              " 'Wow! That’s cleanest this pen has ever been! How would you like to work here permanentlyas my farm-hand?' The Far-mere asks holding out his hand.");
            Console.WriteLine();
        }

        public void AcceptOffer()
        {
            Console.WriteLine($"You shake the Farm-ere’s hand accepting the job. { _goatName} walks up beside you as you all stare into the sunset together. You think you’re going to like it here.");
            Console.WriteLine();
        }

        public void DeclineOffer()
        {
            Console.WriteLine($"You blast the farmer with a shrink ray and feed him to { _goatName}.");
            Console.WriteLine();

        }
    }
}
