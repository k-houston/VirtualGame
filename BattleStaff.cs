using System;
using System.Collections.Generic;
using System.Text;

namespace FightGame
{
    public class BattleStaff
    {

        public int Attack { get; set; }

        public BattleStaff(int attack)
        {
            Attack = attack;
        }

        public void ShowStats()
        {
            Console.WriteLine("The attack power of your battle staff is: " + Attack);
        }
    }
}
