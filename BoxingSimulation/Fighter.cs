using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingSimulation
{
    class Fighter
    {
        public string Name { get; set; } = "Boxer";
        public double Health { get; set; } = 0;
        public double MaxBlock { get; set; } = 0;
        public double MaxAttack { get; set; } = 0;

        Random rdn = new Random();

        

        public string Punch()
        {
            string[] punches = { "Jab", "Cross", "Right Hook", "Left Hook", "Right Uppercut", "Left Uppercut" };
            int i = punches.Length - 1;
            int rndPunch = rdn.Next(0, i);
            return punches[rndPunch];
        }

        public Fighter(string name = "Boxer", double health = 0,double maxBlock=0,double maxAttack = 0)
        {
            Name = name;
            Health = health;
            MaxBlock = maxBlock;
            MaxAttack = maxAttack;
        }

        public double Attack()
        {
            return rdn.Next(1, (int)MaxAttack);
        }

        public double Block()
        {
            return rdn.Next(1, (int)MaxBlock);
        }
    }
}
