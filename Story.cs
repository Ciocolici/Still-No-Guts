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
using System.Xml.Linq;

namespace Still_No_Guts;

internal class Story
{
    public static void Start()
    {
        bool replay = true;
        MainCharacter mainCharacter = new MainCharacter(0, "", 0);
        Friend friend = new Friend(true, "", 0);
        Girlfriend girlfriend = new Girlfriend(true, "", 0);

        do
        {
            Intro();
            MainGame(mainCharacter, friend, girlfriend);

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
    private static void MainGame(MainCharacter mainCharacter, Friend friend, Girlfriend girlfriend)
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
                catch (Exception)
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
            Console.ForegroundColor = ConsoleColor.DarkYellow;
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
        Console.WriteLine($"\nHappy to finally be done with his tasks, {mainCharacter.Name} goes home from work.\nThere, he's so tired, he doesn't even bother showering (not that he does that too often anyway) and goes straight to bed.\n30 seconds later he's already asleep.");
        Thread.Sleep(5000);

        ConsoleKeyInfo playerChoice;
        ConsoleKeyInfo anotherPlayerChoice;
        ConsoleKeyInfo yetAnotherPlayerChoice;

        do
        {
            repeat = false;

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
                    mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 1;
                    do
                    {
                        repeat = false;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(",==========,\r\n|   |  |   |\r\n`-./    \\.-'   \r\n   `.__.'");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n{mainCharacter.Name} doesn't even bother to change and heads outside immediately.\nHowever, it's not until much too late that he realizes he has no clothing except for his underwear. Two girls are already looking at him and laughing.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"-1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"What does {mainCharacter.Name} do then?");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n\n(1) He flirts with the girls.\n(2) He starts to cry and immediately flies back home.\n(3) He continues running to work.");
                        anotherPlayerChoice = Console.ReadKey();

                        if (anotherPlayerChoice.KeyChar == '1')
                        {
                            mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 5;
                            do
                            {
                                Console.Clear();
                                repeat = false;
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("              ., _\t\t\r\n             /    `\t\t\r\n            ((|)))))\t\r\n            ((/ a a\t\t\r\n            )))   >)\t    \r\n           ((((._e((\t    \r\n          ,--/ (-.\t\t   ()))))))\r\n         / \\ <\\/>/|\t\t  ((/ \\)))))\r\n        / /)  Lo )|\t\t  ((),>((((\r\n       / / )    / |\t\t   )\\__ ))\r\n      |   /    ( /\t\t  ( __\\((__\r\n      |  /     ;/\t\t   /  )\\/\\,\\  \r\n      ||(      | \t\t  /.|/ _)_) \\\r\n     / )|/|    \\ \t\t ( \\ \\  o| \\|_\r\n    |/'/\\ \\_____\\\t\t  \\|  )_o| (__\\\r\n         \\   |  \\\t\t _/| /.__|  _/ \\__\r\n          \\  |\\  \\\t\t_(_//  /|\\\\ \\ ||\\.\\\r\n          |  | )  )\t\t   /   \\|/ \\ \\_____\\\r\n          )  )/  /\t\t   '-..___.'\r\n         /  /   /\t\t     \\  |/\r\n        /   |  /\t\t      \\ |\r\n       /    | /\t\t\t     .')|\r\n      /     ||\t\t\t    ( / |\r\n     /      ||\t\t\t    /.\\ |\r\n      '-,_  |_\\\t\t\t  (_ \\ )|\r\n        ( '\"'-`\t\t\t   ) -/ )\r\n         \\(\\_\\\t\t\t    -'_/|");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nWink, wink, and he piqued the interest of both girls. Ten minutes later, he had the phone numbers of both. His luck? They had both been drunk.");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"+5 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"{mainCharacter.Name} found out that they are sisters and live together. He went with both of them to their home, which was not far from his.\nNot long after getting in their apartment, they fell asleep. Being a good guy, he only changed into the male clothes he randomly found on the ground. Yeah, he did steal them.\nQuietly, he goes back outside, and now he has to decide what to do next.");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\n\n(1) Runs to work.\n(2) Calls his employer to apologize.");
                                yetAnotherPlayerChoice = Console.ReadKey();

                                if (yetAnotherPlayerChoice.KeyChar == '1')
                                {
                                    mainCharacter.WorkRun();
                                }
                                else if (yetAnotherPlayerChoice.KeyChar == '2')
                                {
                                    mainCharacter.WorkCall();
                                }
                                else
                                {
                                    repeat = true;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1) or (2).");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\nPress any key to try again.");
                                    Console.ReadKey();
                                }
                            } while (repeat == true);
                        }
                        else if (anotherPlayerChoice.KeyChar == '2')
                        {
                            Console.Clear();
                            mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 1;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("      ,\r\n(`-.-/(           .:::::.,\r\n `-.__)             ``:\\:: .               /7_.-,\r\n     '. -.       -  - `:::'           .- (  `_.=\r\n       \\  `--._   /   _?'`      ___.-'   -`\"'\r\n        \\         -  / )----'''' -    .-'\r\n         `--..   `--' ,'           .-'\r\n              `\\   --'       )---''\r\n                )           )\r\n                |          _|\r\n                (           \\\r\n                 L          /\r\n                 |          \\\r\n                 )__     _   \\\r\n                  \\ `---' `--'\r\n                   L         \\\r\n                   |   \\      \\\r\n                    \\   L     )\r\n                     L_ (      \\\r\n                     |   \\  .  J\r\n                     |    `.    \\\r\n                  _.-`--='  \\    )\r\n                 (   _-'     `--'\\\r\n                  '\"'        / ' J\r\n                            (,_./");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nHe was truly embarrassed. How does he always manage to do this? It's not the first time he's simply forgotten his clothes.");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"-1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("With tears in his eyes, he didn't even realize that he ran past his home.");
                            Thread.Sleep(4000);
                        }
                        else if (anotherPlayerChoice.KeyChar == '3')
                        {
                            mainCharacter.WorkRun();
                        }
                        else
                        {
                            repeat = true;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1), (2) or (3).");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\nPress any key to try again.");
                            Console.ReadKey();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                    } while (repeat == true);
                }
                else if (playerChoice.KeyChar == '3')
                {
                    mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 1;

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(".~~~~.\r\ni====i_\r\n|cccc|_)\r\n|cccc|      \r\n`-==-'");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"\nIf {mainCharacter.Name} hasn't trusted himself enough until now, he surely does now.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"+1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        do
                        {
                            repeat = false;
                            Console.WriteLine($"What does he do then?");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\n\n(1) Opens another beer.\n(2) He tries to call his employer to apologize.\n(3) He rushes to work.");
                            playerChoice = Console.ReadKey();
                            if (playerChoice.KeyChar == '1' && mainCharacter.SelfEsteem < 4)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 1;
                                Console.WriteLine($"Hmm... tastes good!");
                            }
                            else if (playerChoice.KeyChar == '1' && mainCharacter.SelfEsteem >= 4)
                            {
                                do
                                {
                                    repeat = false;
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("That's already enough, otherwise he might get drunk (if he isn't already).\nWhat does he do then?");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\n\n(1) He rushes to work.\n(2) He tries to call his employer to apologize.");
                                    anotherPlayerChoice = Console.ReadKey();
                                    if (anotherPlayerChoice.KeyChar == '1')
                                    {
                                        mainCharacter.WorkRun();
                                    }
                                    else if (anotherPlayerChoice.KeyChar == '2')
                                    {
                                        mainCharacter.WorkCall();
                                    }
                                    else
                                    {
                                        repeat = true;
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1) or (2).");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("\nPress any key to try again.");
                                        Console.ReadKey();
                                    }
                                } while (repeat == true);
                                goto ForLoopExit;
                            }
                            else if (playerChoice.KeyChar == '2')
                            {
                                mainCharacter.WorkCall();
                                goto ForLoopExit;
                            }
                            else if (playerChoice.KeyChar == '3')
                            {
                                mainCharacter.WorkRun();
                                goto ForLoopExit;
                            }
                            else
                            {
                                repeat = true;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1), (2) or (3).");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\nPress any key to try again.");
                                Console.ReadKey();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Clear();
                            }
                        } while (repeat == true);
                    }
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
        } while (repeat == true); // Story Chapter 1

        ForLoopExit:

        do
        {
            repeat = false;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nOn the streets, {mainCharacter.Name} meets someone.\nWho did he meet?");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n(1) Altaïr Ibn-La'Ahad\n(2) Illidan Stormrage\n(3) Alan Wake");
            playerChoice = Console.ReadKey();

            if (playerChoice.KeyChar == '1')
            {
                friend.Name = "Altaïr Ibn-La'Ahad";
            }
            else if (playerChoice.KeyChar == '2')
            {
                friend.Name = "Illidan Stormrage";
            }
            else if (playerChoice.KeyChar == '3')
            {
                friend.Name = "Alan Wake";
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
        } while (repeat == true); // Friend name choice
        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            repeat = false;
            Console.WriteLine("How old is he?");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            check = int.TryParse(Console.ReadLine(), out int age);

            if (check == false)
            {
                repeat = true;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nThe age can only contain numbers.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nPress any key to try again.");
                Console.ReadKey();
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
            }
            else
            {
                friend.Age = age;
            }
        } while (repeat == true); // Friend age input
        do
        {
            repeat = false;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("How is his relationship with him?");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n(1) A good friend.\n(2) Just an acquaintance");
            playerChoice = Console.ReadKey();

            if (playerChoice.KeyChar == '1')
            {
                friend.Friendship = true;
            }
            else if (playerChoice.KeyChar == '2')
            {
                friend.Friendship = false;
            }
            else
            {
                repeat = true;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1) or (2).");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nPress any key to try again.");
                Console.ReadKey();
            }
        } while (repeat == true); // Friend relationship choice

        do
        {
            repeat = false;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\"HI!\" was {mainCharacter.Name} greeted by {friend.Name}. As soon as {mainCharacter.Name} heard that, he felt like the sky was falling on him.\nWhat should his reaction be?");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n(1) He stops and greets him back.\n(2) He ignores him and tries to move past him.");
            playerChoice = Console.ReadKey();

            if (playerChoice.KeyChar == '1')
            {
                Console.Clear();
                mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 1;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("      ////^\\\\\\\\\r\n      | ^   ^ |\r\n     @ (o) (o) @\r\n      |   <   |\r\n      |  ___  |\r\n       \\_____/\r\n     ____|  |____\r\n    /    \\__/    \\\r\n   /              \\\r\n  /\\_/|        |\\_/\\\r\n / /  |        |  \\ \\\r\n( <   |        |   > )\r\n \\ \\  |        |  / /\r\n  \\ \\ |________| / /\r\n   \\ \\|        |/ /");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n\"Oh, hey, {friend.Name}, long time no see, how have you been?\"\nAstonishing! He managed to reply without stutter.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"+1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(4000);
                if (friend.Friendship == true)
                {
                    mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 1;
                    Console.WriteLine($"\n\"My man, bro, digga, what's up, my bruddAh!? I'm really good, bro. So glad to run into such a good friend like you here!\"\nThis response has made {mainCharacter.Name} feel really good.");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"+1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Thread.Sleep(4000);
                    if (friend.Age <= 30)
                    {
                        mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 1;
                        Console.WriteLine($"\n{mainCharacter.Name} remembers that {friend.Name} is {friend.Age} years old. He might just be the only friend he has ever made, that young. For a second, he really feels proud of himself for managing that.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"+1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    }
                    else if (friend.Age > 30)
                    {
                        mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 1;
                        Console.WriteLine($"\n{mainCharacter.Name} remembers that {friend.Name} is {friend.Age} years old. His only friend is that old. How has he never managed to make a friend younger than that? Disappointing.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"-1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    }
                    Thread.Sleep(4000);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n\"I'm not so good bro. I overslept and need to hurry to work...\" said {mainCharacter.Name}");
                }
                else if (friend.Friendship == false)
                {
                    mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 1;
                    Console.WriteLine($"\n\"Oh, you're just... {mainCharacter.Name}. I thought you were a friend of mine... well... I'm good, how about you?\"\nThis response has hurt {mainCharacter.Name} deeply.");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"-1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    Thread.Sleep(4000);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n\"I'm not so good bro. I overslept and need to hurry to work...\" said {mainCharacter.Name}");
                    if (friend.Age <= 30)
                    {
                        mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 1;
                        Console.WriteLine($"\n\"I feel you.\" answered {friend.Name}\nThat actually felt good for {mainCharacter.Name}.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"+1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    }
                    else if (friend.Age > 30)
                    {
                        mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 1;
                        Console.WriteLine($"\n\"Bro?! I am {friend.Age} years old. I expected a little bit of respect from you, no matter how old you are yourself.\"\n{mainCharacter.Name} felt ashamed.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"-1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    }
                }

                Thread.Sleep(2000);
                do
                {
                    repeat = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("What does he do next?");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\n(1) He asks him if he has a car. Maybe {friend.Name} could give {mainCharacter.Name} a ride to work.\n(2) He asks him if he'd like to have a drink and talk about their past.");
                    anotherPlayerChoice = Console.ReadKey();
                    if (anotherPlayerChoice.KeyChar == '1')
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("  ______\r\n /|_||_\\`.__\r\n(   _    _ _\\\r\n=`-(_)--(_)-' ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (friend.Friendship == true)
                        {
                            mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 5;
                            Console.WriteLine($"\n\"Dude, you're still as lazy as ever. Seriously. You know what? I genuinely pity you. You just use people. Forget that I exist. YOU WON'T EVEN GET A GOODBYE FROM ME!... CIAO!\"\n{mainCharacter.Name} certainly didn't expect that...");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"-5 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                        }
                        else if (friend.Friendship == false)
                        {
                            mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 2;
                            Console.WriteLine($"\n\"I don't know you, but I would have loved to help you. That is, if my car would work. Surprise: it's broken. So... nope. Can't help you, sorry!\"\n{mainCharacter.Name}, although saddened by not getting the ride, felt somewhat proud that someone had considered helping him.");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"+2 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                        }
                    }
                    else if (anotherPlayerChoice.KeyChar == '2')
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("  _\r\n {_}\r\n |(|\r\n |=|\r\n/   \\\r\n|.--|\r\n||  |\r\n||  |    .    ' .\r\n|'--|  '     \\~~~/\r\n'-=-' \\~~~/   \\_/\r\n       \\_/     Y\r\n        Y     _|_\r\n       _|_");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (friend.Friendship == true)
                        {
                            mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 5;
                            Console.WriteLine($"\n\"Well, I'd love to do it, you know I enjoy talking to you, but unfortunately, I don't have enough free time. But hey, next time, okay? Good luck with your work thing!\"\nTo hear that {friend.Name} would like to do something with him is sure something special for {mainCharacter.Name}.");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"+5 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                        }
                        else if (friend.Friendship == false)
                        {
                            mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 2;
                            Console.WriteLine($"\n\"I don't even know you, but you want to-- what with me? Drink and talk about what? What past? You high? We don't even know each other.\"\nIt seems {mainCharacter.Name} forgot that..");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"-2 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                        }
                    }
                    else
                    {
                        repeat = true;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1) or (2).");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\nPress any key to try again.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    do
                    {
                        repeat = false;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nWhat does he do now?");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n\n(1) Rushes to work.\n(2) He tries to call his employer to apologize.");
                        anotherPlayerChoice = Console.ReadKey();

                        if (anotherPlayerChoice.KeyChar == '1')
                        {
                            mainCharacter.WorkRun();
                        }
                        else if (anotherPlayerChoice.KeyChar == '2')
                        {
                            mainCharacter.WorkCall();
                        }
                        else
                        {
                            repeat = true;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1) or (2).");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\nPress any key to try again.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    } while (repeat == true);
                } while (repeat == true);
            }
            else if (playerChoice.KeyChar == '2')
            {
                Console.Clear();
                mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 1;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("      ////^\\\\\\\\\r\n      | ^   ^ |\r\n     @ (o) (o) @\r\n      |   <   |\r\n      |  ___  |\r\n       \\_____/\r\n     ____|  |____\r\n    /    \\__/    \\\r\n   /              \\\r\n  /\\_/|        |\\_/\\\r\n / /  |        |  \\ \\\r\n( <   |        |   > )\r\n \\ \\  |        |  / /\r\n  \\ \\ |________| / /\r\n   \\ \\|        |/ /");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\"Hey, wait, do I know you!\" shouted {friend.Name} from afar.\nFull of embarrassment, {mainCharacter.Name} looks at him and immediately understands that he noticed that he ignored him.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"-1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\"Ohh.. Hi\" said {mainCharacter.Name} ashamed. \"Sup?\"");

                if (friend.Friendship == true)
                {
                    mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 1;
                    Console.WriteLine($"\n\"My man, bro, digga, what's up, my bruddAh!? I'm really good, bro. So glad to run into such a good friend like you here!\"\nThis response has made {mainCharacter.Name} feel really good.");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"+1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Thread.Sleep(4000);
                    if (friend.Age <= 30)
                    {
                        mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 1;
                        Console.WriteLine($"\n{mainCharacter.Name} remembers that {friend.Name} is {friend.Age} years old. He might just be the only friend he has ever made, that young. For a second, he really feels proud of himself for managing that.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"+1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    }
                    else if (friend.Age > 30)
                    {
                        mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 1;
                        Console.WriteLine($"\n{mainCharacter.Name} remembers that {friend.Name} is {friend.Age} years old. His only friend is that old. How has he never managed to make a friend younger than that? Disappointing.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"-1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    }
                    Thread.Sleep(4000);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n\"I'm not so good bro. I overslept and need to hurry to work...\" said {mainCharacter.Name}");
                }
                else if (friend.Friendship == false)
                {
                    mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 1;
                    Console.WriteLine($"\n\"Oh, you're just... {mainCharacter.Name}. I thought you were a friend of mine... well... I'm good, how about you?\"\nThis response has hurt {mainCharacter.Name} deeply.");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"-1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    Thread.Sleep(4000);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n\"I'm not so good bro. I overslept and need to hurry to work...\" said {mainCharacter.Name}");
                    if (friend.Age <= 30)
                    {
                        mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 1;
                        Console.WriteLine($"\n\"I feel you.\" answered {friend.Name}\nThat actually felt good for {mainCharacter.Name}.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"+1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    }
                    else if (friend.Age > 30)
                    {
                        mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 1;
                        Console.WriteLine($"\n\"Bro?! I am {friend.Age} years old. I expected a little bit of respect from you, no matter how old you are yourself.\"\n{mainCharacter.Name} felt ashamed.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"-1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    }
                }

                Thread.Sleep(2000);
                do
                {
                    repeat = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("What does he do next?");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\n(1) He asks him if he has a car. Maybe {friend.Name} could give {mainCharacter.Name} a ride to work.\n(2) He asks him if he'd like to have a drink and talk about their past.");
                    anotherPlayerChoice = Console.ReadKey();
                    if (anotherPlayerChoice.KeyChar == '1')
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("  ______\r\n /|_||_\\`.__\r\n(   _    _ _\\\r\n=`-(_)--(_)-' ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (friend.Friendship == true)
                        {
                            mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 5;
                            Console.WriteLine($"\n\"Dude, you're still as lazy as ever. Seriously. You know what? I genuinely pity you. You just use people. Forget that I exist. YOU WON'T EVEN GET A GOODBYE FROM ME!... CIAO!\"\n{mainCharacter.Name} certainly didn't expect that...");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"-5 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                        }
                        else if (friend.Friendship == false)
                        {
                            mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 2;
                            Console.WriteLine($"\n\"I don't know you, but I would have loved to help you. That is, if my car would work. Surprise: it's broken. So... nope. Can't help you, sorry!\"\n{mainCharacter.Name}, although saddened by not getting the ride, felt somewhat proud that someone had considered helping him.");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"+2 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                        }
                    }
                    else if (anotherPlayerChoice.KeyChar == '2')
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("  _\r\n {_}\r\n |(|\r\n |=|\r\n/   \\\r\n|.--|\r\n||  |\r\n||  |    .    ' .\r\n|'--|  '     \\~~~/\r\n'-=-' \\~~~/   \\_/\r\n       \\_/     Y\r\n        Y     _|_\r\n       _|_");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (friend.Friendship == true)
                        {
                            mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 5;
                            Console.WriteLine($"\n\"Well, I'd love to do it, you know I enjoy talking to you, but unfortunately, I don't have enough free time. But hey, next time, okay? Good luck with your work thing!\"\nTo hear that {friend.Name} would like to do something with him is sure something special for {mainCharacter.Name}.");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"+5 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                        }
                        else if (friend.Friendship == false)
                        {
                            mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 2;
                            Console.WriteLine($"\n\"I don't even know you, but you want to-- what with me? Drink and talk about what? What past? You high?\"\nIt seems {mainCharacter.Name} forgot that..");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"-2 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                        }
                    }
                    else
                    {
                        repeat = true;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1) or (2).");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\nPress any key to try again.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    do
                    {
                        repeat = false;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nWhat does he do now?");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n\n(1) Rushes to work.\n(2) He tries to call his employer to apologize.");
                        anotherPlayerChoice = Console.ReadKey();

                        if (anotherPlayerChoice.KeyChar == '1')
                        {
                            mainCharacter.WorkRun();
                        }
                        else if (anotherPlayerChoice.KeyChar == '2')
                        {
                            mainCharacter.WorkCall();
                        }
                        else
                        {
                            repeat = true;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1) or (2).");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\nPress any key to try again.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    } while (repeat == true);
                } while (repeat == true);
            }
            else
            {
                repeat = true;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1) or (2).");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nPress any key to try again.");
                Console.ReadKey();
            }

        } while (repeat == true); // Story Chapter 2: The friend

        girlfriend.Age = mainCharacter.Age + 5;
        do
        {
            repeat = false;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nOn the way, {mainCharacter.Name} encounters his ex-girlfriend. Yes, unbelievable, but he once had one too. The only one, but that's just details.\nWhat was her name?");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n(1) Hinata Hyuga\n(2) Jaina Proudmoore\n(3) Evie Frye");
            playerChoice = Console.ReadKey();

            if (playerChoice.KeyChar == '1')
            {
                girlfriend.Name = "Hinata Hyuga";
            }
            else if (playerChoice.KeyChar == '2')
            {
                girlfriend.Name = "Jaina Proudmoore";
            }
            else if (playerChoice.KeyChar == '3')
            {
                girlfriend.Name = "Evie Frye";
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
        } while (repeat == true); // Girlfriend name choice
        do
        {
            repeat = false;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"How was {girlfriend.Name}?");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n(1) Smexy.\n(2) Looks are not everything");
            playerChoice = Console.ReadKey();

            if (playerChoice.KeyChar == '1')
            {
                girlfriend.Smexy = true;
            }
            else if (playerChoice.KeyChar == '2')
            {
                girlfriend.Smexy = false;
            }
            else
            {
                repeat = true;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1) or (2).");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nPress any key to try again.");
                Console.ReadKey();
            }
        } while (repeat == true); // Girlfriend smexy choice

        do
        {
            repeat = false;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" /////////////\\\\\\\\\r\n(((((((((((((( \\\\\\\\\r\n))) ~~      ~~  (((\r\n((( (*)     (*) )))\r\n)))     <       (((\r\n((( '\\______/`  )))\r\n)))\\___________/(((\r\n       _) (_\r\n      / \\_/ \\\r\n     /(     )\\\r\n    // )___( \\\\\r\n    \\\\(     )//\r\n     (       )\r\n      |  |  |\r\n       | | |\r\n       | | |\r\n      _|_|_|_");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\"BOYAAAH!\" {mainCharacter.Name} was startled by {girlfriend.Name}.\nHow can that even be? Meeting two people on the same day? He usually doesn't see anyone except his colleagues every day...\nWhat should he do?");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n(1) Remains speechless and drools.\n(2) Attempts to communicate with her like normal people.");
            playerChoice = Console.ReadKey();

            if (playerChoice.KeyChar == '1')
            {
                Console.Clear();
                mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 3;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("///-\\\\\\\r\n|^   ^|\r\n|O   O|\r\n|  ~  |\r\n \\ O /\r\n  | |");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nHe stares at her speechless and drools, while she... does the same, looking back at him. For a whole 10 minutes. Only then does {mainCharacter.Name} realize that {girlfriend.Name} is high.\nBut still... someone looked at him for 10 consecutive minutes. Unbelievable.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"+3 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(3000);
                if (girlfriend.Smexy == true)
                {
                    mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 2;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nMoreover, the fact that {girlfriend.Name} is so smexy is a boost to his self-confidence. No matter what, a smexy lady is looking at him. Still looking.");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"+2 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                }
                else if (girlfriend.Smexy == false)
                {
                    mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 2;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nBut he immediately wakes up when he looks at her more closely. {girlfriend.Name} has really become ugly. Uhm, she was before too. But now he somehow finds her even uglier.");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"-2 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                }
                Thread.Sleep(3000);
                do
                {
                    repeat = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"So much time wasted for nothing, he has to quickly decide what he wants to do. He only remembers one detail... she is 5 years older than him.\n\nHow old was she?");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    check = int.TryParse(Console.ReadLine(), out int age);

                    if (check == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\'You're as beautiful as ever\' he lies to her.\'You don't even look {age} years old\'.");
                        Thread.Sleep(2000);
                        if (age == girlfriend.Age)
                        {
                            mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 1;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\'Aww, you're so sweet, you even remembered how old I am.\'");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"+1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                        }
                        else if (age != girlfriend.Age)
                        {
                            mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 1;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\n\'You're kind, but I'm actually {girlfriend.Age} years old. A bit disappointing that you forgot.\'");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"-1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                        }
                    }
                    else if (check == false)
                    {
                        repeat = true;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nThe age can only contain numbers.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\nPress any key to try again.");
                        Console.ReadKey();
                    }
                } while (repeat == true);
                Thread.Sleep(2000);
                do
                {
                    repeat = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nWhat does he do now?");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\n(1) He asks {girlfriend.Name} if she would like to go home with him.\n(2) He explains his situation and asks for understanding to leave.");
                    anotherPlayerChoice = Console.ReadKey();

                    if (anotherPlayerChoice.KeyChar == '1')
                    {
                        Console.Clear();
                        mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 5;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("      .--.___.----.___.--._\r\n     /|  |   |    |   |  | `--.\r\n    /                          `.\r\n   |       |        |           |\r\n   |       |        |      |     |\r\n   |  `    |  `     |    ` |     |\r\n   |    `  |      ` |      |   ` |\r\n  '|  `    | ` ` `  |  ` ` |  `  |\r\n  ||`   `  |     `  |   `  |`   `|\r\n  ||  `    |  `     | `    |  `  |\r\n  ||    `  |   ` `  |    ` | `  `|\r\n  || `     | `      | ` `  |  `  |\r\n  ||  ___  |  ____  |  __  |  _  |\r\n  | \\_____/ \\______/ \\____/ \\___/\r\n  |     `----._\r\n  |    /       \\\r\n  |         .--.\\\r\n  |        '    \\\r\n  `.      |  _.-'\r\n     `.|__.-'");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\'Boooy, I looked at you just because I feel good, 'cause I'm high... you don't think I miss you or anything like thaaaat... You've remained disrespectful as ever... embarrassing. So, screw off! I'm gone, ciao!\'");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"-5 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    }
                    else if (anotherPlayerChoice.KeyChar == '2')
                    {
                        Console.Clear();
                        mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 5;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("          .--------._\r\n         (`--'       `-.\r\n          `.______      `.\r\n       ___________`__     \\\r\n    ,-'           `-.\\     |\r\n   //                \\|    |\\\r\n  (`  .'~~~~~---\\     \\'   | |\r\n   `-'           )     \\   | |\r\n      ,---------' - -.  `  . '\r\n    ,'             `%`\\`     |\r\n   /                      \\  |\r\n  /     \\-----.         \\    `\r\n /|  ,_/      '-._            |\r\n(-'  /           /            `     \r\n,`--<           |        \\     \\\r\n\\ |  \\         /%%             `\\\r\n |/   \\____---'--`%        \\     \\\r\n |    '           `               \\\r\n |\r\n  `--.__\r\n        `---._______\r\n                    `.\r\n                      \\");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n\'Alles klar, darling, I understand. I really missed you, but if that's how it is, then so be it. Don't worry, we'll see each other sometime. Good luck with your thing!\'\nTo hear that {girlfriend.Name} missed him... that's sure something for {mainCharacter.Name}!");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"+5 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    }
                    else
                    {
                        repeat = true;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1) or (2).");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\nPress any key to try again.");
                        Console.ReadKey();
                    }
                } while (repeat == true);
                Thread.Sleep(4000);
                do
                {
                    repeat = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nWhat does he do now?");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\n(1) Runs to work.\n(2) He tries to call his employer to apologize..");
                    anotherPlayerChoice = Console.ReadKey();

                    if (anotherPlayerChoice.KeyChar == '1')
                    {
                        mainCharacter.WorkRun();
                    }
                    else if (anotherPlayerChoice.KeyChar == '2')
                    {
                        mainCharacter.WorkCall();
                    }
                    else
                    {
                        repeat = true;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1) or (2).");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\nPress any key to try again.");
                        Console.ReadKey();
                    }
                } while (repeat == true);
            }
            else if (playerChoice.KeyChar == '2')
            {
                Console.Clear();
                mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 2;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("      ////\\\\\\\\\r\n      |      |\r\n     @  O  O  @\r\n      |  ~   |   \r\n       \\ -- /    \r\n     ___|  |___ ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nHe tries to communicate with her, but unfortunately, all that comes out is \"HmUhmHHHHHHHmmmUHmm\".");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"-2 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(3000);
                if (girlfriend.Smexy == true)
                {
                    mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 2;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nMoreover, the fact that {girlfriend.Name} is so smexy kills his self-confidence. No matter what, a smexy lady is looking at him. Still looking.");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"-2 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                }
                else if (girlfriend.Smexy == false)
                {
                    mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 2;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nBut he immediately wakes up when he looks at her more closely. {girlfriend.Name} has really become ugly. Uhm, she was before too. But now he somehow finds her even uglier. Knowing he's not the only one, it boosts his self-confidence");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"+2 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                }
                Thread.Sleep(3000);
                do
                {
                    repeat = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"So much time wasted for nothing, he has to quickly decide what he wants to do. He only remembers one detail... she is 5 years older than him.\n\nHow old was she?");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    check = int.TryParse(Console.ReadLine(), out int age);

                    if (check == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\'You're as beautiful as ever\' he lies to her.\'You don't even look {age} years old\'.");
                        Thread.Sleep(2000);
                        if (age == girlfriend.Age)
                        {
                            mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 1;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\'Aww, you're so sweet, you even remembered how old I am.\'");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"+1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                        }
                        else if (age != girlfriend.Age)
                        {
                            mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 1;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\n\'You're kind, but I'm actually {girlfriend.Age} years old. A bit disappointing that you forgot.\'");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"-1 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                        }
                    }
                    else if (check == false)
                    {
                        repeat = true;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nThe age can only contain numbers.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\nPress any key to try again.");
                        Console.ReadKey();
                    }
                } while (repeat == true);
                Thread.Sleep(2000);
                do
                {
                    repeat = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nNow what?!");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\n(1) {mainCharacter.Name} + {girlfriend.Name} = L0v3.\n(2) Wink, wink, goodbye!");
                    anotherPlayerChoice = Console.ReadKey();

                    if (anotherPlayerChoice.KeyChar == '1')
                    {
                        Console.Clear();
                        mainCharacter.SelfEsteem = mainCharacter.SelfEsteem - 5;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("      .--.___.----.___.--._\r\n     /|  |   |    |   |  | `--.\r\n    /                          `.\r\n   |       |        |           |\r\n   |       |        |      |     |\r\n   |  `    |  `     |    ` |     |\r\n   |    `  |      ` |      |   ` |\r\n  '|  `    | ` ` `  |  ` ` |  `  |\r\n  ||`   `  |     `  |   `  |`   `|\r\n  ||  `    |  `     | `    |  `  |\r\n  ||    `  |   ` `  |    ` | `  `|\r\n  || `     | `      | ` `  |  `  |\r\n  ||  ___  |  ____  |  __  |  _  |\r\n  | \\_____/ \\______/ \\____/ \\___/\r\n  |     `----._\r\n  |    /       \\\r\n  |         .--.\\\r\n  |        '    \\\r\n  `.      |  _.-'\r\n     `.|__.-'");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n{mainCharacter.Name} was never good at flirting. So, one can imagine what happened next. Of course, when he invited {girlfriend.Name} for coffee, it took him minutes to ask the question. At last, when he finally opened his eyes again, she was no longer there.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"-5 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    }
                    else if (anotherPlayerChoice.KeyChar == '2')
                    {
                        Console.Clear();
                        mainCharacter.SelfEsteem = mainCharacter.SelfEsteem + 5;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("          .--------._\r\n         (`--'       `-.\r\n          `.______      `.\r\n       ___________`__     \\\r\n    ,-'           `-.\\     |\r\n   //                \\|    |\\\r\n  (`  .'~~~~~---\\     \\'   | |\r\n   `-'           )     \\   | |\r\n      ,---------' - -.  `  . '\r\n    ,'             `%`\\`     |\r\n   /                      \\  |\r\n  /     \\-----.         \\    `\r\n /|  ,_/      '-._            |\r\n(-'  /           /            `     \r\n,`--<           |        \\     \\\r\n\\ |  \\         /%%             `\\\r\n |/   \\____---'--`%        \\     \\\r\n |    '           `               \\\r\n |\r\n  `--.__\r\n        `---._______\r\n                    `.\r\n                      \\");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\nHe did the same thing he did years ago. Wink, wink, and a goodbye, and she was beside him, imploring for a date. But, {mainCharacter.Name}, being the cool person he is, apologized because he, of course, had something else urgent to do.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"+5 self-esteem. Current: {mainCharacter.SelfEsteem}.");
                    }
                    else
                    {
                        repeat = true;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1) or (2).");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\nPress any key to try again.");
                        Console.ReadKey();
                    }
                } while (repeat == true);
                Thread.Sleep(4000);
                do
                {
                    repeat = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nWhat does he do now?");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\n(1) Runs to work.\n(2) He tries to call his employer to apologize..");
                    anotherPlayerChoice = Console.ReadKey();

                    if (anotherPlayerChoice.KeyChar == '1')
                    {
                        mainCharacter.WorkRun();
                    }
                    else if (anotherPlayerChoice.KeyChar == '2')
                    {
                        mainCharacter.WorkCall();
                    }
                    else
                    {
                        repeat = true;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1) or (2).");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\nPress any key to try again.");
                        Console.ReadKey();
                    }
                } while (repeat == true);
            }
            else
            {
                repeat = true;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1) or (2).");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nPress any key to try again.");
                Console.ReadKey();
            }
        } while (repeat == true); // Story Chapter 3: The girlfriend

        if (mainCharacter.SelfEsteem < 5)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{mainCharacter.Name}, with only {mainCharacter.SelfEsteem} self-esteem, has realized that he is just an ant in the scale of the universe.\nSo, he decided to leave his job and start selling drugs. Because it's easier, and more profitable, of course.");
            Thread.Sleep(4000);
            Console.WriteLine("\nUnfortunately, 10 minutes later, he was caught by the police and thrown into prison immediately.\nWhere he was found dead 2 days later. No one knows why, but also, no one cares, lol.");
            Thread.Sleep(4000);
            Console.WriteLine($"\nWhat do we learn? Don't be like {mainCharacter.Name}, or do, who cares?! I don't. ^^");
            Thread.Sleep(4000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n  ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  \r\n ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒\r\n▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒\r\n░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  \r\n░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒\r\n ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░\r\n  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░\r\n░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░ \r\n      ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░     \r\n                                                     ░                   ");
            Thread.Sleep(1000);
            Console.WriteLine("\n\n  ▄▄▄▄    ▄▄▄      ▓█████▄    ▓█████  ███▄    █ ▓█████▄  ██▓ ███▄    █   ▄████ \r\n▓█████▄ ▒████▄    ▒██▀ ██▌   ▓█   ▀  ██ ▀█   █ ▒██▀ ██▌▓██▒ ██ ▀█   █  ██▒ ▀█▒\r\n▒██▒ ▄██▒██  ▀█▄  ░██   █▌   ▒███   ▓██  ▀█ ██▒░██   █▌▒██▒▓██  ▀█ ██▒▒██░▄▄▄░\r\n▒██░█▀  ░██▄▄▄▄██ ░▓█▄   ▌   ▒▓█  ▄ ▓██▒  ▐▌██▒░▓█▄   ▌░██░▓██▒  ▐▌██▒░▓█  ██▓\r\n░▓█  ▀█▓ ▓█   ▓██▒░▒████▓    ░▒████▒▒██░   ▓██░░▒████▓ ░██░▒██░   ▓██░░▒▓███▀▒\r\n░▒▓███▀▒ ▒▒   ▓▒█░ ▒▒▓  ▒    ░░ ▒░ ░░ ▒░   ▒ ▒  ▒▒▓  ▒ ░▓  ░ ▒░   ▒ ▒  ░▒   ▒ \r\n▒░▒   ░   ▒   ▒▒ ░ ░ ▒  ▒     ░ ░  ░░ ░░   ░ ▒░ ░ ▒  ▒  ▒ ░░ ░░   ░ ▒░  ░   ░ \r\n ░    ░   ░   ▒    ░ ░  ░       ░      ░   ░ ░  ░ ░  ░  ▒ ░   ░   ░ ░ ░ ░   ░ \r\n ░            ░  ░   ░          ░  ░         ░    ░     ░           ░       ░ \r\n      ░            ░                            ░                             ");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nPress any key to view the credits.");
            Console.ReadKey();
            Story.Credits();
        }
        else
        {
            mainCharacter.WorkCall();
        }

    }

    public static void Credits()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Credits & thanks to:");
        Thread.Sleep(1500);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n\nLutz & Grub AG - for teaching me the basics of C# programming");
        Thread.Sleep(1500);
        Console.WriteLine("\nASCII Art Archive - for the ASCII pics");
        Thread.Sleep(1500);
        Console.WriteLine("\nPatorjk - for the ASCII titles");
        Thread.Sleep(1500);
        Console.WriteLine("\nGithub - for hosting the game");
        Thread.Sleep(1500);
        Console.WriteLine("\nChatGPT - for fixing my grammar.. hah");
        Thread.Sleep(1500);
        Console.WriteLine("\nCîrjeu Daniel Marian (Cioco/Ciocolici/me/myself) - for creating this game LOL");
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
