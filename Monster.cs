using System;
using System.Collections.Generic;
using System.Text;

namespace FightGame
{
    public class Monster
    {
        public int Health { get; set; } = 100;

        public int MonsterAttack { get; set; }

        public Monster (int health, int attack)
        {
            Health = health;
            MonsterAttack = attack;
        }

        public void Attack(Monster monster, User user)
        {
            Console.WriteLine("The Monster Attacks You!\nThe Monster stomps on you and inflicts: " + monster.MonsterAttack + " " + "damage");
            user.Health -= monster.MonsterAttack;
            Console.WriteLine("The health of the user: " + user.Health);
        }
    }
}
