using System;

namespace FightGame
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User(100, new Sword(12), new BowArrow(10), new BattleStaff(12));
            Monster monster = new Monster(100, 10);
           
            bool userPlay = true;

            while (user.Health > 0 && monster.Health > 0)
            {
                if (userPlay)
                {
                    Console.WriteLine("Are you ready to be a brave warrior?\n");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Here are the instructions to the game.");
                    Console.WriteLine("2. Attack with sword!");
                    Console.WriteLine("3. Attack with BowArrow!");
                    Console.WriteLine("4. Attack with BattleStaff!");
                    Console.WriteLine("5. Check the status of your health and the monster health.");
                    Console.WriteLine("6. Exit Game.");

                    string userChoice = Console.ReadLine().ToLower();
                    Console.Clear();

                    switch (userChoice)
                    {
                        case "1":
                            Console.WriteLine("Welcome to... The objective of the game is to use the weapons available to slay the monster. Hope you are ready for a challenge!");
                            break;
                      
                        case "2":
                            break;
                       
                        case "3":
                            break;
                       
                        case "4":
                            break;
                       
                        case "5":
                            break;
                       
                        case "6":
                            userPlay = false;
                            Console.WriteLine("Good Bye!");
                            break;

                        default:
                            Console.WriteLine("Please enter in a valid number from the menu.");
                            break;

                    }
                }

                Console.WriteLine("Return to the main menu");
                Console.ReadKey();
                Console.Clear();

            } 
        }
    }
}
