using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Still_No_Guts;

internal class Story
{
    public static void Start()
    {
        bool replay = true;

        do
        {
            Intro();

        } while (replay == true);
    }

    public static void Intro()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\r\n (                                 )                                      \r\n )\\ )      )        (    (      ( /(           (                  )       \r\n(()/(   ( /(   (    )\\   )\\     )\\())          )\\ )       (    ( /(       \r\n /(_))  )\\())  )\\  ((_) ((_)   ((_)\\    (     (()/(      ))\\   )\\())  (   \r\n(_))   (_))/  ((_)  _    _      _((_)   )\\     /(_))_   /((_) (_))/   )\\  \r\n/ __|  | |_    (_) | |  | |    | \\| |  ((_)   (_)) __| (_))(  | |_   ((_) \r\n\\__ \\  |  _|   | | | |  | |    | .` | / _ \\     | (_ | | || | |  _|  (_-< \r\n|___/   \\__|   |_| |_|  |_|    |_|\\_| \\___/      \\___|  \\_,_|  \\__|  /__/ \r\n                                                                          \r\n");
        Thread.Sleep(3000);
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\nThis is a story about someone who apparently never had guts. Even today he's got ");
        Thread.Sleep(3000);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("Still ");
        Thread.Sleep(1000);
        Console.Write("No ");
        Thread.Sleep(1000);
        Console.Write("Guts");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\nWill that change today?");
        Thread.Sleep(2000);
        Console.WriteLine("\nPress any key to start the game.");
        Console.ReadKey();
    }
}
