using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingSimulation
{
    class Fight
    {
        public static void StartFight(Fighter boxer1,Fighter boxer2)
        {
            while (true)
            {
                if(GetAttackResult(boxer1,boxer2)=="Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }if(GetAttackResult(boxer2,boxer1)=="Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }

        }
        public static string GetAttackResult(Fighter boxer1,Fighter boxer2)
        {
            double boxer1Attack = boxer1.Attack();
            double boxer2Block = boxer2.Block();

            double damageToBoxer2 = boxer1Attack - boxer2Block;

            if (damageToBoxer2 > 0)
            {
                boxer2.Health = boxer2.Health - damageToBoxer2;
            }
            else
            {
                damageToBoxer2 = 0;
            }
            Console.WriteLine("{0} attacks {1} with {2} and deals {3} damage",boxer1.Name,boxer2.Name, boxer1.Punch(), damageToBoxer2);
            Console.WriteLine("{0} health is {1}",boxer2.Name, boxer2.Health);

            if (boxer2.Health <= 0)
            {
                Console.WriteLine("{0} is KO'd and {1} is the winner",boxer2.Name,boxer1.Name);
                return "Game Over";
            }
            else
            {
                return "Fight Again";
            }
        }
    }
}
