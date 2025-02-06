using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartanTeamProject
{
    public class Player
    {
        string Name { get; set; }
        int Level { get; set; }
        string Job {  get; set; }
        float Attack { get; set; }
        float Deffense { get; set; }
        float Health { get; set; }
        float MaxHealth { get; set; }
        float Gold { get; set; }

        public Player(string name, int level, string job, float attack, float deffense, float health, float maxHealth, float gold)
        {
            Name = name;
            Level = level;
            Job = job; 
            Attack = attack;
            Deffense = deffense;
            Health = health;
            MaxHealth = maxHealth;
            Gold = gold;
        }
    }
}
