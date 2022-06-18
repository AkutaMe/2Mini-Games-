using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace minigames
{
    internal class Character
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int MaxHealth { get; protected set; }       
        public string TextArt { get; protected set; }
        public ConsoleColor Color { get; protected set; }
        public Random RandGenerator { get; protected set; }
        public bool isDead { get => Health <= 0; }
        public bool isAlive { get => Health > 0; }

        public Character(string name, int health, ConsoleColor color, string textArt)
        {
            Name = name;
            Health = health;
            MaxHealth=health;
            Color = color;
            TextArt = textArt;
            RandGenerator = new Random();
        }
        public void DisplayInfo()
        {
            BackgroundColor  = Color;
            Write($"---{Name}---");
            ResetColor();

            ForegroundColor = Color;
            Console.WriteLine($"\n{TextArt}\n");
            Console.WriteLine($"Health: {Health}\n");
            Console.WriteLine("---");
            ResetColor();
        }
        public virtual void Fight( Character otherCharacter)
        {
            ForegroundColor = Color;
            Console.WriteLine(otherCharacter.Name);
            WriteLine("Enemy is fighting!");
        }
        public void TakeDamage(int damageAmount)
        {
            Health -= damageAmount;
            if(Health < 0)
            {
                Health = 0;
            }
        }
        public void DisplayHealthBar()
        {
            ForegroundColor= Color;
            Console.WriteLine($"{Name}'s Health:");
            ResetColor();
            Write("[");
            BackgroundColor = ConsoleColor.Green;
            for(int i = 0; i < Health; i++)
            {
                Write(" ");
            }
            BackgroundColor = ConsoleColor.Black;
            for(int i = Health; i < MaxHealth; i++)
            {
                Write(" ");
            }
            ResetColor();
            WriteLine($"] ({Health}/{MaxHealth})");
            
        }
    }
}
