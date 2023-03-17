using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warrior_Fight
{
    public class Fight
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if(Stage(warrior1, warrior2)=="Game Over")
                {
                    Console.WriteLine($"{warrior1.Name} has won the duel");
                    break;
                }

                if (Stage(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine($"{warrior2.Name} has won a duel");
                    break;
                }
            }
        }

        public static string Stage(Warrior warriorA, Warrior warriorB)
        {
            int dmg;
            dmg = warriorA.GetAttack() - warriorB.GetBlock();
            if (dmg < 0)
            {
                dmg = 0;
            }
            else
            {
                warriorB.Health-=dmg;
            }

            Console.WriteLine($"{warriorA.Name} attacked {warriorB} dealing {dmg} damage");
            Console.WriteLine($"{warriorB.Name} has {warriorB.Health} health");
            Console.WriteLine();

            return (warriorB.Health > 0) ? "Fight continues" : "Game Over";
            
        }
    }
}
