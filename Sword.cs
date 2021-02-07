using System;
using System.Collections.Generic;
using System.Text;

namespace FightGame
{
    public class Sword
    {
        public int Attack { get; set; }

        public Sword(int attack)
        {
            Attack = attack;
        }

        public void ShowStats()
        {
            Console.WriteLine("The attack power of your sword is: " + Attack);
        }
    }
}
