using System;
using System.Collections.Generic;
using RPG.Models;
namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Human Tyler = new Human("Tyler");
            Human Bot = new Human("FightBot", 5, 5 ,5 ,60);
            Console.WriteLine($"{Bot.Name} is created!");
            Bot.ShowStats();
            // Wizard Tyler = new Wizard("Tyler");
            // Ninja Tyler = new Ninja("Tyler");
            Samurai Tyler = new Samurai("Tyler");
            Console.WriteLine($"{Tyler.Name} is created!");
            Tyler.ShowStats();
            // Tyler.Attack(Bot);
            // Tyler.DrainLife(Bot);
            // Tyler.BladeDance(Bot);
            // Tyler.ContemptfortheWeak(Bot);
            // Tyler.Heal(Bot);
            // Tyler.Steal(Bot);
            Bot.Attack(Tyler);
            Tyler.ShowStats();
            Tyler.Meditate();
            Tyler.ShowStats();
            
        }
    }
}
