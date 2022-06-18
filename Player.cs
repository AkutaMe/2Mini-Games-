using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace minigames
{
    internal class Player : Character
    {
        public Player(string name, int health, ConsoleColor color)
            : base(name, health, color, ArtAssets.Player)
        {

        }
        private void ThrowDirtAT(Character otherCharacter)
        {
            Write("u threw a pile of dirt");
            int randPercent = RandGenerator.Next(1, 101);
            if (randPercent <= 70)
            {
                Console.WriteLine("and it hit!!");
                otherCharacter.TakeDamage(3);
            }
            else
            {
                Console.WriteLine("and it missed...");
            }
        }
        
        private void SwingAt(Character otherCharacter)
        {
            Write("u drank a cup of lean, took a mighty swing ");
            int randPercent = RandGenerator.Next(1, 101);
            if (randPercent <= 50)
            {
                Console.WriteLine("and it hit solidly!");
                otherCharacter.TakeDamage(9);
            }
            else
            {
               
                Console.WriteLine("but it missed...");

            }
        }
        public override void Fight(Character otherCharacter)
        {
           // WriteLine($"Player {Name} attacks {otherCharacter.Name}");

            ForegroundColor = Color;
            Console.WriteLine($@"u are facing {otherCharacter.Name}. What attack  would you like to do?

  1)pick up a pile of dirt and throw it.(90% chance to do 3 damage)

  2)drink a cup of lean and take a mighty swing with a twig.(50% chance to do 9 damage)

");
            ConsoleKeyInfo keyinfo = ReadKey(true);
            if (keyinfo.Key == ConsoleKey.D1)
            {
                ThrowDirtAT(otherCharacter);
            }
            else if(keyinfo.Key == ConsoleKey.D2)
            {
                SwingAt(otherCharacter);
            }
            
            else
            {
                Console.WriteLine("not a valid move. try again");
                Fight(otherCharacter);
                return;
            }
            ResetColor();
        }
    }
}
