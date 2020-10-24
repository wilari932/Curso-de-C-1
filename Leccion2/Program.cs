using System;

namespace Leccion2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Cual es tu edad? ");
            string input =  Console.ReadLine();
            int edad = int.Parse(input);
            //SI
            if(edad >= 18) 
            {
              
                //el codigo que quermos ejecutar 
                Console.WriteLine("bienvenido!");
            }
            else
            {
                Console.WriteLine("Vete de aqui eres un niño");
            }

        

        }
    }
}
