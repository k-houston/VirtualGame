using System;

namespace FightGame
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User(new Sword (10), new BowArrow(8), new BattleStaff(12));
            Monster monster = new Monster(100, 12);
            Random random = new Random();
           
            bool gameOver = false;
            bool userTurn = true;

            while (!gameOver)
            {
                if (userTurn)
                {
                    Console.WriteLine("Are you ready to be a brave warrior?\n");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Here are the instructions to the game.");
                    Console.WriteLine("2. Attack with Sword!");
                    Console.WriteLine("3. Attack with BowArrow!");
                    Console.WriteLine("4. Attack with BattleStaff!");
                    Console.WriteLine("5. Exit Game.");

                    string userChoice = Console.ReadLine().ToLower();
                    Console.Clear();

                    switch (userChoice)
                    {
                        case "1":
                            Console.WriteLine("Welcome to... The objective of the game is to use the weapons available to slay the monster. Hope you are ready for a challenge!");
                            break;
                      
                        case "2":
                            user.Attack(user.Sword, monster);
                            Console.WriteLine($"Health of monster: {monster.Health}");
                            break;
                       
                        case "3":
                            user.Attack(user.BowNArrow, monster);
                            Console.WriteLine($"Health of monster: {monster.Health}");
                            break;
                       
                        case "4":
                            user.Attack(user.BattleStaff, monster);
                            Console.WriteLine($"Health of monster: {monster.Health}");
                            break;
                       
                        case "5":
                            gameOver = true;
                            Console.WriteLine("Good Bye!");
                            break;

                        default:
                            Console.WriteLine("Please enter in a valid number from the menu.");
                            break;

                    }
                    userTurn = !userTurn;
                }

                else 
                {
                    int num = random.Next(2);
                   
                    if (num % 2 == 0)
                    {
                        monster.Attack(monster, user);
                    }
                    
                    userTurn = !userTurn;
                }

                if (user.Health > 0 && monster.Health <= 0)
                {
                    gameOver = true;
                    Console.WriteLine("Congratulations! You have defeated the monster!");
                }

                else if (monster.Health > 0 && user.Health <= 0)
                {
                    gameOver = true;
                    Console.WriteLine("Game over. You have been defeated!");
                }

                Console.WriteLine("Return to the main menu");
                Console.ReadKey();
                Console.Clear();

           
            } 
        }
    }
}
