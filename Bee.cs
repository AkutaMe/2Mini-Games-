using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace minigames
{
    internal class Bee :Character   
    {
        public bool HasPoisonSting { get; set; }


        public Bee(string name, int health, ConsoleColor color,bool haspoison)
            : base(name, health, color, ArtAssets.Bee)
        {

            HasPoisonSting = haspoison;
        }
        public void Fly()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine(" spitting lean!");
        }
        public void Sting()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            Write(" lunges forward with their");

            if (HasPoisonSting)
            {
                Console.WriteLine(" lean powers and stings u poisonously");
            }
            else
            {
                Console.WriteLine(" sharp stinger!");
            }
        }
        public override void Fight(Character otherCharacter)
        {

            ForegroundColor = Color;
            WriteLine($"Bee - {Name} is fighting {otherCharacter.Name}!");
            int randPercent = RandGenerator.Next(1, 101);
            if (randPercent <= 20)
            {
                Console.WriteLine("lunged forward with their lean powers and stung you poisonously");
                otherCharacter.TakeDamage(20);
            }
            else if (HasPoisonSting = true && randPercent <= 101)
            {
                Console.WriteLine("it spat you lean!dealt 1 damage");
                otherCharacter.TakeDamage(1);
            }
            else if(randPercent <= 80)
            {
                Console.WriteLine("bladee took u to the air! - dealt 3 damage");
                otherCharacter.TakeDamage(3);
            }
            else
            {
                Console.WriteLine("misses...");
            }
            ResetColor();
        }
    }
}
