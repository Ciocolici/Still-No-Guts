using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Still_No_Guts.Characters;

internal class MainCharacter : DefaultCharacter
{
    public MainCharacter(int selfEsteem, string name, int age) : base(name, age)
    {
        SelfEsteem = selfEsteem;
    }

    public int SelfEsteem { get; set; }

    public void WorkCall()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" __i\r\n|---|    \r\n|[_]|    \r\n|:::|    \r\n|:::|    \r\n`\\   \\   \r\n  \\_=_\\ ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        if (SelfEsteem >= 5)
        {
            Console.WriteLine($"\nWith a self-esteem of {SelfEsteem}, {Name} managed to call his employer. After such an adventure, he finally trusted himself to do that.");
            Thread.Sleep(4000);
            Console.WriteLine($"\nOf course, he was fired immediately, couldn't find a new job, ended up on the street, and a year later, he was eaten by wild animals, but that's not the most important part.\nWhat's important is that he finally saw his self-worth.\n\nWhat do we learn from this story? I have no idea. Think it over for yourself, I can't do everything for you.");
            Thread.Sleep(4000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ \r\n██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗\r\n██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝\r\n██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗\r\n╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║\r\n ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝\r\n                                                                          ");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\n ██████╗  ██████╗  ██████╗ ██████╗     ███████╗███╗   ██╗██████╗ ██╗███╗   ██╗ ██████╗ \r\n██╔════╝ ██╔═══██╗██╔═══██╗██╔══██╗    ██╔════╝████╗  ██║██╔══██╗██║████╗  ██║██╔════╝ \r\n██║  ███╗██║   ██║██║   ██║██║  ██║    █████╗  ██╔██╗ ██║██║  ██║██║██╔██╗ ██║██║  ███╗\r\n██║   ██║██║   ██║██║   ██║██║  ██║    ██╔══╝  ██║╚██╗██║██║  ██║██║██║╚██╗██║██║   ██║\r\n╚██████╔╝╚██████╔╝╚██████╔╝██████╔╝    ███████╗██║ ╚████║██████╔╝██║██║ ╚████║╚██████╔╝\r\n ╚═════╝  ╚═════╝  ╚═════╝ ╚═════╝     ╚══════╝╚═╝  ╚═══╝╚═════╝ ╚═╝╚═╝  ╚═══╝ ╚═════╝ \r\n                                                                                       ");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n░▀█▀░█▀█░░░▀█▀░█░█░█▀▀░█▀█░█▀▄░█░█\r\n░░█░░█░█░░░░█░░█▀█░█▀▀░█░█░█▀▄░░█░\r\n░▀▀▀░▀░▀░░░░▀░░▀░▀░▀▀▀░▀▀▀░▀░▀░░▀░");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nPress any key to view the credits.");
            Console.ReadKey();
            Story.Credits();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{Name} tries and tries, but unfortunately, his self-esteem of {SelfEsteem} is too little to hold his phone in his hand... He trembles... and starts to cry... He now understands that he needs a minimum self-esteem of 5 to trust himself to call his employer.");
            SelfEsteem = SelfEsteem - 1;

            ConsoleKeyInfo playerChoice;
            bool repeat;

            do
            {
                repeat = false;
                Console.WriteLine($"After a few minutes, he remembers that he never accomplishes anything right.\n{Name} loses 1 self-esteem. Then {Name}:");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n\n(1) Slaps himself twice and regaines his composure.\n(2) Gets up immediately.");
                playerChoice = Console.ReadKey();
                if (playerChoice.KeyChar == '1')
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("       _.-/`)\r\n         // / / )\r\n      .=// / / / )\r\n     //`/ / / / /\r\n    // /     ` /\r\n   ||         /\r\n    \\\\       /\r\n     ))    .'\r\n    //    /\r\n         /");
                    SelfEsteem = SelfEsteem + 1;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n{Name} now understands his purpose in life.");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"+1 self-esteem. Current: {SelfEsteem}.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("He now knows what must be done");
                    Thread.Sleep(4000);
                }
                else if (playerChoice.KeyChar == '2')
                {
                    if (SelfEsteem >= 2)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("       _.-/`)\r\n         // / / )\r\n      .=// / / / )\r\n     //`/ / / / /\r\n    // /     ` /\r\n   ||         /\r\n    \\\\       /\r\n     ))    .'\r\n    //    /\r\n         /");
                        SelfEsteem = SelfEsteem + 2;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nHaving enough self-esteem, he felt confident about what he needed to do next and easily managed to stand up.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"+2 self-esteem. Current: {SelfEsteem}.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("He now knows what must be done");
                        Thread.Sleep(4000);
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("   __\r\n  (__)\r\n  |()| \r\n _|()|_ _\r\n(()()()())\r\n(        |\r\n(        |\r\n \\      /\r\n  |     |");
                        SelfEsteem = SelfEsteem - 1;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n{Name}, because he wasn't confident enough in his {SelfEsteem} self-esteem, he slipped back down.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"-1 self-esteem. Current: {SelfEsteem}.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nevertheless, an inner voice tells him that he should still try to go there.");
                        Thread.Sleep(4000);
                    }
                }
                else
                {
                    repeat = true;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nInvalid choice.\nPlease select a valid option: (1) or (2)");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nPress any key to try again.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            } while (repeat == true);
        }
    }

    public void WorkRun()
    {
        if (SelfEsteem >= 1)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("     _\r\n   _| |\r\n _| | |\r\n| | | |\r\n| | | | __\r\n| | | |/  \\\r\n|       /\\ \\\r\n|      /  \\/\r\n|      \\  /\\\r\n|       \\/ /\r\n \\        /\r\n  |     /\r\n  |    |");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nWith a self-esteem of {SelfEsteem}, {Name} managed to run without anything getting in his way. Unbelievable, isn't it?\nAnd for that, he gains an additional +3 self-esteem because he never thought he could run 20 meters consecutively without falling on the ground.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            SelfEsteem = SelfEsteem + 3;
            Console.WriteLine($"+3 self-esteem. Current: {SelfEsteem}.");
            Thread.Sleep(4000);
        }
        else
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("     __\r\n    (__)\r\n    |__| \r\n  __|__|_ _\r\n /|_|_/_/ /|\r\n(  (_)__)J-)\r\n(  /`.,   /\r\n \\/  ;   /\r\n  | === |");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{Name} keeps trying, and trying, but unfortunately, his self-esteem of {SelfEsteem} is far too low to manage to run and he's falling to the ground like a fool.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            SelfEsteem = SelfEsteem - 3;
            Console.WriteLine($"-3 self-esteem. Current: {SelfEsteem}.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("After a few minutes, he gets up, feeling sad, and remembers that he never succeeds at anything.");
            Thread.Sleep(4000);
        }
    }
}
