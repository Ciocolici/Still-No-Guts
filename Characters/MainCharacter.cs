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
            Console.WriteLine($"\n{Name} tries and tries, but unfortunately, his self-esteem of {SelfEsteem} is too little to hold his phone in his hand... He trembles... and starts to cry... He now understands that he needs a minimum self-esteem of 5 to trust himself to call his employer.");
            SelfEsteem = SelfEsteem - 1;

            ConsoleKeyInfo playerChoice;
            bool repeat;

            do
            {
                repeat = false;
                Console.WriteLine($"");

            } while (repeat == true);
        }
    }
}
