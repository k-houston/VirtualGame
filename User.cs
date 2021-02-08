using System;
using System.Collections.Generic;
using System.Text;

namespace FightGame
{
    public class User
    {

        public int Health { get; set; } = 100;

        public Sword Sword { get; set; }

        public BowArrow BowNArrow { get; set; }

        public BattleStaff BattleStaff { get; set; }

        public User(Sword sword, BowArrow bowNArrow, BattleStaff battleStaff)
        {
            Sword = sword;
            BowNArrow = bowNArrow;
            BattleStaff = battleStaff;
        }

        public void Attack(Sword sword, Monster monster)
        {
            Console.WriteLine("You Attacked The Monster!\n The slash of your sword inflicts: " + sword.Attack + " " + "damage\n");
            monster.Health -= sword.Attack;
        }

        public void Attack(BowArrow bowArrow, Monster monster)
        {
            Console.WriteLine("You Attacked The Monster!\n The shoot of your arrow inflicts: " + bowArrow.Attack + " " + "damage\n");
            monster.Health -= bowArrow.Attack;
        }

        public void Attack(BattleStaff battleStaff, Monster monster)
        {
            Console.WriteLine("You Attacked The Monster!\n The cast of your battle staff inflicts: " + battleStaff.Attack + " " + "damage\n");
            monster.Health -= battleStaff.Attack;
        }
    }
}
