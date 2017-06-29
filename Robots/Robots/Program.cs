using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bot-Shop. Choose from a list of bots:");
            Console.WriteLine("- 'worker bot'");
            Console.WriteLine("- 'fighter bot'");
            Console.ReadLine();

            Console.CursorLeft = 0;
            Console.Write("[");
            Console.CursorLeft = 30;
            Console.Write("]");
            Console.CursorLeft = 1;

            int position = 1;
            for (int i = 0; i < 29; i++)
            {
                System.Threading.Thread.Sleep(40);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            Console.WriteLine("");
            Console.ResetColor();
            Console.WriteLine("Bootup Success!");
            Console.ReadLine();
        }
    }
}
