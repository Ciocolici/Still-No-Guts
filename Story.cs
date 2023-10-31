using Still_No_Guts.Characters;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Still_No_Guts;

internal class Story
{
    public static void Start()
    {
        bool replay = true;
        MainCharacter mainCharacter = new MainCharacter(0, "", 0);

        do
        {
            //Intro();
            MainGame(mainCharacter);

        } while (replay == true);
    }

    private static void Intro()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\r\n (                                 )                                      \r\n )\\ )      )        (    (      ( /(           (                  )       \r\n(()/(   ( /(   (    )\\   )\\     )\\())          )\\ )       (    ( /(       \r\n /(_))  )\\())  )\\  ((_) ((_)   ((_)\\    (     (()/(      ))\\   )\\())  (   \r\n(_))   (_))/  ((_)  _    _      _((_)   )\\     /(_))_   /((_) (_))/   )\\  \r\n/ __|  | |_    (_) | |  | |    | \\| |  ((_)   (_)) __| (_))(  | |_   ((_) \r\n\\__ \\  |  _|   | | | |  | |    | .` | / _ \\     | (_ | | || | |  _|  (_-< \r\n|___/   \\__|   |_| |_|  |_|    |_|\\_| \\___/      \\___|  \\_,_|  \\__|  /__/ \r\n                                                                          \r\n");
        Thread.Sleep(3000);
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\nThis is a story about someone who apparently never had guts.");
        Thread.Sleep(2000);
        Console.WriteLine("\nEven today he's got");
        Thread.Sleep(3000);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("Still ");
        Thread.Sleep(1000);
        Console.Write("No ");
        Thread.Sleep(1000);
        Console.Write("Guts");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\n\nWill that change today?");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nPress any key to start the game.");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("\nTIP: Press F11 to switch between fullscreen and windowed.");
        Thread.Sleep(5000);
        Console.Clear();
    }
    private static void MainGame(MainCharacter mainCharacter)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("    XXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\n  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\n XXXXXXXXXXXXXXXXXX         XXXXXXXX\r\nXXXXXXXXXXXXXXXX              XXXXXXX\r\nXXXXXXXXXXXXX                   XXXXX\r\n XXX     _________ _________     XXX      \r\n  XX    I  _xxxxx I xxxxx_  I    XX        \r\n ( X----I         I         I----X )           \r\n( +I    I      00 I 00      I    I+ )\r\n ( I    I    __0  I  0__    I    I )\r\n  (I    I______ /   \\_______I    I)\r\n   I           ( ___ )           I\r\n   I    _  :::::::::::::::  _    i\r\n    \\    \\___ ::::::::: ___/    /\r\n     \\_      \\_________/      _/\r\n       \\        \\___,        /\r\n         \\                 /\r\n          |\\             /|\r\n          |  \\_________/  |");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nOur main character is not as sociable as his colleagues, but he loves his work. Programming is indeed his hobby.");

        bool repeat;
        string characterName;

        do
        {
            do
            {
                repeat = false;
                Console.WriteLine("What is his name?");
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    characterName = Console.ReadLine().ToLower();
                    characterName = char.ToUpper(characterName[0]) + characterName.Substring(1);
                    mainCharacter.Name = characterName;
                }
                catch (Exception ex)
                {
                    repeat = true;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nThe name can only contain letters.");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nPress any key to try again.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            } while (repeat == true);
            repeat = false;
            string pattern = @"[^a-zA-Z]";
            bool containsNonAlphabetic = Regex.IsMatch(mainCharacter.Name, pattern);

            if (containsNonAlphabetic)
            {
                repeat = true;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nThe name can only contain letters.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nPress any key to try again.");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        } while (repeat == true); // Character name input

        bool check;

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("    XXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\n  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\n XXXXXXXXXXXXXXXXXX         XXXXXXXX\r\nXXXXXXXXXXXXXXXX              XXXXXXX\r\nXXXXXXXXXXXXX                   XXXXX\r\n XXX     _________ _________     XXX      \r\n  XX    I  _xxxxx I xxxxx_  I    XX        \r\n ( X----I         I         I----X )           \r\n( +I    I      00 I 00      I    I+ )\r\n ( I    I    __0  I  0__    I    I )\r\n  (I    I______ /   \\_______I    I)\r\n   I           ( ___ )           I\r\n   I    _  :::::::::::::::  _    i\r\n    \\    \\___ ::::::::: ___/    /\r\n     \\_      \\_________/      _/\r\n       \\        \\___,        /\r\n         \\                 /\r\n          |\\             /|\r\n          |  \\_________/  |");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nNot too young, but also not too old.");
        do
        {
            repeat = false;
            Console.WriteLine("How old is he anyway?");
            check = int.TryParse(Console.ReadLine(), out int age);

            if (check == false)
            {
                repeat = true;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nThe age can only contain numbers.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nPress any key to try again.");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (age < 18)
            {
                repeat = true;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nThat's a bit too young.");
                Console.WriteLine("The character has to be allowed to work full-time without limitations. His age should be between 18 and 66.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nPress any key to try again.");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (age > 66)
            {
                repeat = true;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nThat's a bit too old.");
                Console.WriteLine("The character has to be allowed to work, not be pensionary. His age should be between 18 and 66.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nPress any key to try again.");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                mainCharacter.Age = age;
            }
        } while (repeat == true); // Character age input

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("              )\r\n             (      _[]_         (\r\n     __[]___[]___[]/____\\_[]_    )\r\n    /______________|[][]|____\\  (\r\n    |[][]|[][]|[][]|[][]|[][]|__[]_\r\n    |  /\\|/\\  |  /\\|  /\\|/\\  |_____\\\r\n    |[]|||||[]|[]|||[]|||||[]|[_]|||\r\n  ===================================\r\n  -  -  -  -  -  -  -  -  -  -  -  -  -\r\n=========================================");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Happy to finally be done with his tasks, {mainCharacter.Name} goes home from work.\nThere, he's so tired, he doesn't even bother showering (not that he does that too often anyway) and goes straight to bed.\n30 seconds later he's already asleep.");
        Thread.Sleep(5000);

        do
        {
            repeat = false;
            ConsoleKeyInfo playerChoice;

            do
            {
                repeat = false;
                Console.WriteLine($"\nThe next day, he wakes up, only to realize that it's already 2 PM.\nHis alarm clock didn't ring at all. He usually starts work at 7 AM.\n\nWith a self-esteem of {mainCharacter.SelfEsteem}, what does {mainCharacter.Name} do?");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n\n(1) He tries to call his employer to apologize.\n(2) He quickly rushes to work, hoping that maybe no one will notice.\n(3) He opens up a beer.");
                playerChoice = Console.ReadKey();

                if (playerChoice.KeyChar == '1')
                {
                    mainCharacter.WorkCall();
                }
                else if (playerChoice.KeyChar == '2')
                {

                }
                else if (playerChoice.KeyChar == '3')
                {

                }
                else
                {
                    repeat = true;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1), (2) or (3).");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nPress any key to try again.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            } while (repeat == true);

        } while (repeat == true);


    }
    
    public static void Credits()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Credits & thanks to:");
        Thread.Sleep(1500);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nLutz & Grub AG - for teaching me the basics of C# programming");
        Thread.Sleep(1500);
        Console.WriteLine("\nASCII Art Archive - for the ASCII pics");
        Thread.Sleep(1500);
        Console.WriteLine("\nPatorjk - for the ASCII titles");
        Thread.Sleep(1500);
        Console.WriteLine("\nGithub - for hosting the game");
        Thread.Sleep(1500);
        Console.WriteLine("\nChatGPT - for fixing my grammar.. hah");
        Thread.Sleep(1500);
        Console.WriteLine("\nCîrjeu Daniel Marian (Cioco/Ciocolici/myself) - for creating this game LOL");
        Thread.Sleep(2500);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nYOU - for playing the game");
        Thread.Sleep(3000);
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\n\nThank you so much for playing my game! (:");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Press any key to exit the game.");
        Console.ReadKey();
        Environment.Exit(0);
    }
}
