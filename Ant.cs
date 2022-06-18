using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace minigames
{
    internal class Ant : Character
    {
        private int ChargeDistance;
        private Item CurrentItem;
        public Ant(string name,int health,ConsoleColor color,int chargeDistance)
            :base(name,health,color, ArtAssets.Ant)
        {
            ChargeDistance = chargeDistance;
        } 
        public void PickUpItem(Item item)
        {
            CurrentItem = item;
        }
        public void Charge()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();

            Console.WriteLine($" Charges swiftly forward {ChargeDistance} centimeters!");

            if(CurrentItem != null)
            {
                WriteLine($"They are carrying a {CurrentItem.Name}");
            }
        }
        public void Bite()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();

            Console.WriteLine($" viciously Bites!");
        }
        public override void Fight(Character otherCharacter)
        {


            ForegroundColor = Color;
            WriteLine($"Ant - {Name} is fighting {otherCharacter.Name}!");
            int randPercent = RandGenerator.Next(1, 101);
           // Write($"Ant {Name} bites at {otherCharacter.Name} and ");
            if (randPercent <= 50)
            {
                Console.WriteLine("hits for 4 damage");
                otherCharacter.TakeDamage(4);
            }
            else
            {
                Console.WriteLine("misses...");
            }
        ResetColor();
        }
    }
}
