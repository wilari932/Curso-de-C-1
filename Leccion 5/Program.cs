using System;

namespace Leccion_5
{
    class Program
    {
        // do while 
        static void Main(string[] args)
        {
            // el do while es igual que while la unica diferencia es que este te da la garantia de que el codigo se ejecutara al menos una vez 



            //int a = 0;
            //do
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}
            //while (a < 5);


            PasswordScore score = PasswordScore.VeryStrong;
            do
            {
                Console.WriteLine("Este programa se terminara cuando tengas una clave fuerte");
                Console.Write("Escribe tu clave :");
                string password = Console.ReadLine();

                score = PasswordChecker.CheckStrength(password);
                if (score != PasswordScore.VeryStrong)
                {
                    Console.Write("Tu clave es muy devil intenta otra vez");
                }
            }
            while (score != PasswordScore.VeryStrong);
            Console.WriteLine("Tu clave es bastante fuerte");

            Console.ReadKey();


        }
    }
}
