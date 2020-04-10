using System;
namespace RPG.Models
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

        public int BladeDance(Human target)
        {
            Random random = new Random();
            int possibility = random.Next(1, 10);
            if (possibility > 8)
            {
                int dmg = (5 * Dexterity) * 2;
                target.Health -= dmg;
                Console.WriteLine($"Critical Hit!!! {Name} used Bladedance to {target.Name} and dealt {dmg} damage!");
                return target.Health;
            }
            else
            {
                int dmg = 5 * Dexterity;
                target.Health -= dmg;
                Console.WriteLine($"{Name} used Bladedance to {target.Name} and dealt {dmg} damage!");
                return target.Health;
            }
        }

        public int Steal(Human target)
        {
            int dmg = Dexterity;
            target.Health -= dmg;
            Health += dmg;
            Console.WriteLine($"{Name} used Steal to {target.Name} and dealt {dmg} damage and healed {dmg}!");
            return target.Health;

        }
    }
}
