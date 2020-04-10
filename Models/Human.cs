using System;
namespace RPG.Models
{
    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Health;

        // private int HP;
        // public int Health
        // {
        //     get
        //     {
        //         return HP;
        //     }
        // }
        
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        public Human(string name, int Str, int Int, int Dex, int HP)
        {
            Name = name;
            Strength = Str;
            Intelligence = Int;
            Dexterity = Dex;
            Health = HP;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}\n Strength: {Strength}\n Intelligence: {Intelligence}\n Dexterity: {Dexterity}\n HP: {Health}");
        }
        public int Attack(Human target)
        {   
            int dmg = 5 * Strength;
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} and dealt {dmg} damage!");
            return target.Health;
        }
    }
}