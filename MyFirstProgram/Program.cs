using System;
using System.Net;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Program
    {
        // Caules son los tipos de datos primitivos en C#
        // como declarar una variable con ellos
        // Como se usan
        // los operados logicos || && !
        // los operadores aritmeticos + - * /
        // los operadores relacionales < > != == >= <=
        // los operadores Bitwise Operators

        static void Main(string[] args)
        {
           


            // cuenta
            double cuenta = 0;
            // mensaje 
            Console.WriteLine("Cuanto deseas depositar ?");
            //leyendo la entrada 
            string input = Console.ReadLine();
            // la entrada del usuario a tipo double  
            double transaction = double.Parse(input);

            // sumar el dinero ala cuneta 
            cuenta += transaction;


            Console.WriteLine("Tienes este dinero en tu cuenta "+ cuenta );

            //cuenta = cuenta + transaction;


        
            // mensaje 
            Console.WriteLine("Cuanto deseas sacar ?");
            //leyendo la entrada 
               input = Console.ReadLine();
            // la entrada del usuario a tipo double  
             transaction = double.Parse(input);

            // sumar el dinero ala cuneta 
            cuenta -= transaction;
            //cuenta = cuenta - transaction;

            Console.WriteLine("Tienes este dinero en tu cuenta " + cuenta);

            //cuenta = cuenta + transaction;




        }

       
    }
}
