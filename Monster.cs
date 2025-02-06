using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace SpartanTeamProject
{
    public class Monster 
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public double Health { get; set; }
        public double MaxHealth { get; set; }
        public double Attack { get; set; }

        public Monster(string name, int level, double health, double maxHealth, double attack)
        {
            Name = name;
            Level = level;
            Health = health;
            MaxHealth = maxHealth;
            Attack = attack;
        }


    }
}
