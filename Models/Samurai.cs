using System;
namespace RPG.Models
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            Health = 200;
        }
        public int ContemptfortheWeak(Human target)
        {
            int dmg = 5 * Strength;
            target.Health -= dmg;
            if( target.Health > 50)
            {
                Console.WriteLine($"{Name} attacked {target.Name} and dealt {dmg} damage!");
                return target.Health;
            }
            else
            {
                target.Health = 0;
                Console.WriteLine($"{Name} attacked {target.Name} and dealt {dmg} damage!");
                Console.WriteLine($"Passive 'Contempt for the Week' activated. INSTAKILL!!");
                return target.Health;
            }
        }
        public int Meditate()
        {
            Health = 200;
            Console.WriteLine($"{Name} used Meditate and fully recovered!");
            return Health;
        }
    }        
}
