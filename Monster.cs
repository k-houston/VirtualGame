using System;
using System.Collections.Generic;
using System.Text;

namespace FightGame
{
    public class Monster
    {
        public int Health { get; set; }

        public int MonsterAttack { get; set; }

        public Monster (int health, int attack)
        {
            Health = health;
            MonsterAttack = attack;
        }

        public void Attack(Monster monster, User user)
        {
            Console.WriteLine("The Monster Attacks You!\nThe Monster stomps on you and inflicts: " + monster.MonsterAttack);
            user.Health -= monster.MonsterAttack;
        }
    }
}
