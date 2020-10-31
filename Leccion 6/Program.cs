using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Leccion_6
{
    class Program
    {
        static int x,y = 0;
     
        static void Main(string[] args)
        {
         
            var key = ConsoleKey.Y;

            do
            {
                key = Console.ReadKey().Key;
                
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(x, y);
                Console.Write("*/n*");

                Console.SetCursorPosition(x, y);
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (1 <= x - 5)
                        {
                            x -= 5;
                        }

                        break;
                    case ConsoleKey.RightArrow:
                        if (Console.BufferWidth >= x + 5)
                        {
                            x += 5;
                        }

                        break;

                    case ConsoleKey.DownArrow:
                        if (Console.BufferHeight >= y - 1)
                        {
                            y += 1;
                        }

                        break;
                    case ConsoleKey.UpArrow:
                        if (1 <= y - 1)
                        {
                            y -= 1;
                        }

                        break;
                }
             

            } while (Console.ReadKey().Key != ConsoleKey.Y);
         
            Console.ReadKey();
          


        }
    }
}
