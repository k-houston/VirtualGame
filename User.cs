using System;
using System.Collections.Generic;
using System.Text;

namespace FightGame
{
    public class User
    {

        public int Health { get; set; }

        public string Sword { get; set; }

        public string BowNArrow { get; set; }

        public string BattleStaff { get; set; }

        public User(int health, string sword, string bowNArrow, string battleStaff)
        {
            Health = health;
            Sword = sword;
            BowNArrow = bowNArrow;
            BattleStaff = battleStaff;
        }

        public void Attack(Sword sword, Monster monster)
        {
            Console.WriteLine("You Attacked The Monster!\n The slash of your sword inflicts: " + sword.Attack + "amount of damage\n");
            monster.Health -= sword.Attack;
        }

        public void Attack(BowArrow bowArrow, Monster monster)
        {
            Console.WriteLine("You Attacked The Monster!\n The shoot of your arrow inflicts: " + bowArrow.Attack + "amount of damage\n");
            monster.Health -= bowArrow.Attack;
        }

        public void Attack(BattleStaff battleStaff, Monster monster)
        {
            Console.WriteLine("You Attacked The Monster!\n The cast of your battle staff inflicts: " + battleStaff.Attack + "amount of damage\n");
            monster.Health -= battleStaff.Attack;
        }
    }
}
