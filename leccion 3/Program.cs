using System;

namespace leccion_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Cual es tu edad? ");
            string input = Console.ReadLine();
            int edad = int.Parse(input);
            //SI
            
            if (edad >= 18 && edad < 20)
            {

                //el codigo que quermos ejecutar 
                Console.WriteLine("eres adulto pero eres menor a 20");
            }
            else if (edad >= 20)
            {
                Console.WriteLine("eres adulto y mayor o igual a 20");
            }
            else
            {
                Console.WriteLine("Vete de aqui eres un niño");
            }
        }
    }
}
