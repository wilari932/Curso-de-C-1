using System;
using System.Web;
namespace GoogleTranslate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("traductor 1.1:");
            do
            {
                var t = new Translator();
                var input = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(t.Translate(input));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("si deseas serar el traductor oprime f7 o presiona cualquiera para seguir");
            } while (Console.ReadKey().Key != ConsoleKey.F7);
          
        }
    }
}
