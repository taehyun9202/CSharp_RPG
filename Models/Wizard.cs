using System;
using System.Collections.Generic;
namespace RPG.Models
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 200;
            Health = 50;
        }
        public int DrainLife(Human target)
        {   
            int dmg = 5 * Intelligence;
            target.Health -= dmg;
            Console.WriteLine($"{Name} used DrainLife to {target.Name} and dealt {dmg} damage and healed {dmg}!");
            Health += dmg;
            return target.Health;
        }
        public int Heal(Human target)
        {
            int heal = 10 * Intelligence;
            target.Health += heal;
            Console.WriteLine($"{Name} used Heal to {target.Name} and healed for {heal}!");
            return target.Health;
        }
    }
}

