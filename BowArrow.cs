using System;
using System.Collections.Generic;
using System.Text;

namespace FightGame
{
    public class BowArrow
    {
        public int Attack { get; set; }


        public BowArrow(int attack)
        {
            Attack = attack;
        }

        public void ShowStats()
        {
            Console.WriteLine("The attack power of your bow is: " + Attack);
        }




    }
}
