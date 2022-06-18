using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace minigames
{
    public class Game
    {
        private Player CurrentPlayer;
        private Character CurrentEnemy;
        private List<Character> Enemies;
        public Game()
        {
            
            Ant ecco2k = new Ant("ecco2k", 10, ConsoleColor.Red, 3);

            Ant leandoer = new Ant("leandoer", 20, ConsoleColor.Magenta, 6);
            Item CupofLean = new Item("CupofLean", 10);
            leandoer.PickUpItem(CupofLean);

            Bee  Bladee = new Bee("Bladee", 50, ConsoleColor.DarkYellow,true);  

            Enemies = new List<Character>() {ecco2k, leandoer , Bladee};
        }
        private static void printHangman(int wrong)
        {
            if (wrong == 0)
            {
                Clear();
                Console.WriteLine(@"
  _      __    __                     __         __ __                             
 | | /| / /__ / /______  __ _  ___   / /____    / // /__ ____  ___ ___ _  ___ ____ 
 | |/ |/ / -_) / __/ _ \/  ' \/ -_) / __/ _ \  / _  / _ `/ _ \/ _ `/  ' \/ _ `/ _ \
 |__/|__/\__/_/\__/\___/_/_/_/\__/  \__/\___/ /_//_/\_,_/_//_/\_, /_/_/_/\_,_/_//_/
                                                             /___/                 
");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("\n+---+");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 1)
            {
                Clear();
                Console.WriteLine(@"
  _      __    __                     __         __ __                             
 | | /| / /__ / /______  __ _  ___   / /____    / // /__ ____  ___ ___ _  ___ ____ 
 | |/ |/ / -_) / __/ _ \/  ' \/ -_) / __/ _ \  / _  / _ `/ _ \/ _ `/  ' \/ _ `/ _ \
 |__/|__/\__/_/\__/\___/_/_/_/\__/  \__/\___/ /_//_/\_,_/_//_/\_, /_/_/_/\_,_/_//_/
                                                             /___/                 
");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 2)
            {
                Clear();
                Console.WriteLine(@"
  _      __    __                     __         __ __                             
 | | /| / /__ / /______  __ _  ___   / /____    / // /__ ____  ___ ___ _  ___ ____ 
 | |/ |/ / -_) / __/ _ \/  ' \/ -_) / __/ _ \  / _  / _ `/ _ \/ _ `/  ' \/ _ `/ _ \
 |__/|__/\__/_/\__/\___/_/_/_/\__/  \__/\___/ /_//_/\_,_/_//_/\_, /_/_/_/\_,_/_//_/
                                                             /___/                 
");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 3)
            {
                Clear();
                Console.WriteLine(@"
  _      __    __                     __         __ __                             
 | | /| / /__ / /______  __ _  ___   / /____    / // /__ ____  ___ ___ _  ___ ____ 
 | |/ |/ / -_) / __/ _ \/  ' \/ -_) / __/ _ \  / _  / _ `/ _ \/ _ `/  ' \/ _ `/ _ \
 |__/|__/\__/_/\__/\___/_/_/_/\__/  \__/\___/ /_//_/\_,_/_//_/\_, /_/_/_/\_,_/_//_/
                                                             /___/                 
");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|  |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 4)
            {
                Clear();
                Console.WriteLine(@"
  _      __    __                     __         __ __                             
 | | /| / /__ / /______  __ _  ___   / /____    / // /__ ____  ___ ___ _  ___ ____ 
 | |/ |/ / -_) / __/ _ \/  ' \/ -_) / __/ _ \  / _  / _ `/ _ \/ _ `/  ' \/ _ `/ _ \
 |__/|__/\__/_/\__/\___/_/_/_/\__/  \__/\___/ /_//_/\_,_/_//_/\_, /_/_/_/\_,_/_//_/
                                                             /___/                 
");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 5)
            {
                Clear();
                Console.WriteLine(@"
  _      __    __                     __         __ __                             
 | | /| / /__ / /______  __ _  ___   / /____    / // /__ ____  ___ ___ _  ___ ____ 
 | |/ |/ / -_) / __/ _ \/  ' \/ -_) / __/ _ \  / _  / _ `/ _ \/ _ `/  ' \/ _ `/ _ \
 |__/|__/\__/_/\__/\___/_/_/_/\__/  \__/\___/ /_//_/\_,_/_//_/\_, /_/_/_/\_,_/_//_/
                                                             /___/                 
");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/   |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 6)
            {
                Clear();
                Console.WriteLine(@"
  _      __    __                     __         __ __                             
 | | /| / /__ / /______  __ _  ___   / /____    / // /__ ____  ___ ___ _  ___ ____ 
 | |/ |/ / -_) / __/ _ \/  ' \/ -_) / __/ _ \  / _  / _ `/ _ \/ _ `/  ' \/ _ `/ _ \
 |__/|__/\__/_/\__/\___/_/_/_/\__/  \__/\___/ /_//_/\_,_/_//_/\_, /_/_/_/\_,_/_//_/
                                                             /___/                 
");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O   |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine("/ \\  |");
                Console.WriteLine("    ===");
            }
        }

        private static int printWord(List<char> guessedLetters, String randomWord)
        {
            int counter = 0;
            int rightLetters = 0;
            Console.Write("\r\n");
            foreach (char c in randomWord)
            {
                if (guessedLetters.Contains(c))
                {
                    Console.Write(c + " ");
                    rightLetters += 1;
                }
                else
                {
                    Console.Write("  ");
                }
                counter += 1;
            }

            return rightLetters;
        }

        private static void printLines(String randomWord)
        {
            Console.Write("\r");
            foreach (char c in randomWord)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write("\u0305 ");
            }
        }
        public void Start()
        {
            Title = "Mini-Games";
            RunMainMenu();

        }
        private void RunMainMenu()
        {

            string prompt = @" 
   __  ____      _         _____                 
  /  |/  (_)__  (_) ____  / ___/__ ___ _  ___ ___
 / /|_/ / / _ \/ / /___/ / (_ / _ `/  ' \/ -_|_-<
/_/  /_/_/_//_/_/        \___/\_,_/_/_/_/\__/___/
                                                 
";


            string[] options = { @"Hangman", @"scientist vs leansects", @"Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    RunFirst();
                    break;
                case 1:
                    RunSecond();              
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }

        private void ExitGame()
        {
            Console.WriteLine("\n Press any key to exit...");
            Console.ReadKey();
            Environment.Exit(0);
        }
        public void RunFirst()
        {
            Clear();
            Console.WriteLine(@"
  _      __    __                     __         __ __                             
 | | /| / /__ / /______  __ _  ___   / /____    / // /__ ____  ___ ___ _  ___ ____ 
 | |/ |/ / -_) / __/ _ \/  ' \/ -_) / __/ _ \  / _  / _ `/ _ \/ _ `/  ' \/ _ `/ _ \
 |__/|__/\__/_/\__/\___/_/_/_/\__/  \__/\___/ /_//_/\_,_/_//_/\_, /_/_/_/\_,_/_//_/
                                                             /___/                 
");
            Console.WriteLine("-----------------------------------------");

            Random random = new Random();
            List<string> words = new List<string> { "saxli", "magida", "karebi", "gamarjoba", "cxoveli", "adamiani", "skola", "universiteti" };
            int index = random.Next(words.Count);
            String rndWord = words[index];

            foreach (char x in rndWord)
            {
                Console.Write("_ ");
            }

            int length = rndWord.Length;
            int Wrong = 0;
            List<char> LettersGuessed = new List<char>();
            int Right = 0;

            while (Wrong != 6 && Right != length)
            {
                Console.Write("\nLetters guessed so far: ");
                foreach (char letter in LettersGuessed)
                {
                    Console.Write(letter + " ");
                }

                Console.Write("\nGuess a letter: ");
                char letterGuessed = Console.ReadLine()[0];

                if (LettersGuessed.Contains(letterGuessed))
                {
                    Console.Write("\r\n You have already guessed this letter");
                    printHangman(Wrong);
                    Right = printWord(LettersGuessed, rndWord);
                    printLines(rndWord);
                }
                else
                {

                    bool right = false;
                    for (int i = 0; i < rndWord.Length; i++) { if (letterGuessed == rndWord[i]) { right = true; } }


                    if (right)
                    {
                        printHangman(Wrong);

                        LettersGuessed.Add(letterGuessed);
                        Right = printWord(LettersGuessed, rndWord);
                        Console.Write("\r\n");
                        printLines(rndWord);
                    }

                    else
                    {
                        Wrong += 1;
                        LettersGuessed.Add(letterGuessed);

                        printHangman(Wrong);

                        Right = printWord(LettersGuessed, rndWord);
                        Console.Write("\r\n");
                        printLines(rndWord);
                    }
                }
                Console.ReadLine();
            }
            Console.WriteLine("\r\nGame is over! Thank you for playing");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\n Press any key to exit...");
            Console.ReadKey();
            Environment.Exit(0);

        }
        public void RunSecond()
        {
            RunIntro();

            for (int i = 0; i < Enemies.Count; i += 1)
            {
                CurrentEnemy = Enemies[i];

                IntroCurrentEnemy();
                BattleCurrentEnemy();

                if (CurrentPlayer.isDead)
                {
                    Console.WriteLine("you were defeated");
                    WaitForkey();
                    break;
                }
                else 
                { Console.WriteLine($"you defetead {CurrentEnemy.Name}!");
                    WaitForkey();
                }
            }
           RunGameOver();
        }
        private void RunIntro()
        {

            Clear();
            WriteLine(@"
           _            _   _     _                 _                                _       
          (_)          | | (_)   | |               | |                              | |      
  ___  ___ _  ___ _ __ | |_ _ ___| |_  __   _____  | | ___  __ _ _ __  ___  ___  ___| |_ ___ 
 / __|/ __| |/ _ \ '_ \| __| / __| __| \ \ / / __| | |/ _ \/ _` | '_ \/ __|/ _ \/ __| __/ __|
 \__ \ (__| |  __/ | | | |_| \__ \ |_   \ V /\__ \ | |  __/ (_| | | | \__ \  __/ (__| |_\__ \
 |___/\___|_|\___|_| |_|\__|_|___/\__|   \_/ |___/ |_|\___|\__,_|_| |_|___/\___|\___|\__|___/
                                                                                             
                                                                                             
");

            WriteLine("\n----------------------------------------\n");
            Write("What is your name? ");
            string name = ReadLine();
            CurrentPlayer = new Player(name, 40, ConsoleColor.Green);

            ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"You wake up outside and look around at a field of blades of grass towering over you
     /  /          \
/   /   \          /   \
\   \   /          \   /  /
/   /  /     o   \  \  \  \
\  /  /  /  /|\  /  /  /  /
 \ \  \ /   / \  \ /   \ / 
");
            ResetColor();
            WaitForkey();
            Clear();
            Console.WriteLine($@"scientific experiment didnt go too well... 
accidentally you shrunk yourself down to the size of an ants...
you look around and see a colony of leansects has taken an interest in you...
looks like you have to fight your way out to the leanlab


are you ready? uve got {Enemies.Count}x leansect to face..");
            CurrentPlayer.DisplayInfo();
            
            WaitForkey();

           
        }

        private void RunGameOver()
        {
            Clear();
            if (CurrentPlayer.isDead)
            {
                Console.WriteLine(@"
     )    )            (        )   (               ____ 
  ( /( ( /(            )\ )  ( /(   )\ )  *   )    |   / 
  )\()))\())     (    (()/(  )\()) (()/(` )  /(    |  /  
 ((_)\((_)\      )\    /(_))((_)\   /(_))( )(_))   | /   
__ ((_) ((_)  _ ((_)  (_))    ((_) (_)) (_(_())    |/    
\ \ / // _ \ | | | |  | |    / _ \ / __||_   _|   (      
 \ V /| (_) || |_| |  | |__ | (_) |\__ \  | |     )\     
  |_|  \___/  \___/   |____| \___/ |___/  |_|    ((_)    
                                                         
 
your journey has come to an end.. u couldnt make it back to your leanlab this time.Try again");
            }
            else
            {
                Console.WriteLine(@"
     )    )                        )      )     ____ 
  ( /( ( /(            (  (     ( /(   ( /(    |   / 
  )\()))\())     (     )\))(   ')\())  )\())   |  /  
 ((_)\((_)\      )\   ((_)()\ )((_)\  ((_)\    | /   
__ ((_) ((_)  _ ((_)  _(())\_)() ((_)  _((_)   |/    
\ \ / // _ \ | | | |  \ \((_)/ // _ \ | \| |  (      
 \ V /| (_) || |_| |   \ \/\/ /| (_) || .` |  )\     
  |_|  \___/  \___/     \_/\_/  \___/ |_|\_| ((_)    
                                                     
your journey is over you defeated all the bosses!!!!
you made it back to ur leanlab. now u can return urself to a normal size!
");
            }
            Console.WriteLine("thanks for playing!");
            WriteLine();
            WaitForkey();
        }
        private void IntroCurrentEnemy()
        {
            Clear();
            ForegroundColor = CurrentEnemy.Color;
            Console.WriteLine($"A new leansect approaches!!");
            ResetColor();
            CurrentEnemy.DisplayInfo();
            WriteLine();
            
            WaitForkey();
        }

        private void BattleCurrentEnemy()
        {
            while (CurrentEnemy.isAlive && CurrentPlayer.isAlive)
            {
                Clear();
                CurrentPlayer.DisplayInfo();
                WriteLine();
                CurrentPlayer.DisplayHealthBar();
                WriteLine();
                CurrentEnemy.DisplayInfo();
                WriteLine();
                CurrentEnemy.DisplayHealthBar();
                WriteLine();


                CurrentPlayer.Fight(CurrentEnemy);


                WriteLine();


                WaitForkey();


                if (CurrentPlayer.isDead || CurrentEnemy.isDead)
                {
                    break;
                }
                Clear();
                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();
                WriteLine();

                CurrentEnemy.Fight(CurrentPlayer);


                WaitForkey();


            }
        }
        private void WaitForkey()
        {
            WriteLine("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
