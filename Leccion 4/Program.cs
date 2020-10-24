
using NAudio.Wave;
using System;
using System.Threading;

namespace Leccion_4
{
    class Program
    {
        // el bucle while 
        static void Main(string[] args)
        {
            /* 
              el bucle while necista una condicion
              si la condicion es verdadera 
              ejecutara el bloquee de codigo asignado 
              dentro de sus llaves 
          */
            //int numero = 1;

            //while (numero <= 10)
            //{
            //    // escribe el valor actual de la variable numero
            //    Console.WriteLine(numero);
            //    // le sumamos uno a la variable numero
            //    numero++;
            //}
            /* 
              El ejemplo que tenemos arriba 
              declara una variable igual a uno y
              el ciclo while verifica la condicion 
              si la condicion es verdadera 
              ejecutara el bloque de codigo asignado 
              dentro de sus llaves (cuerpo)

          */
            //implemataremos un despertador y un reproductor de audio
            // implementaremos la libreria de NAudio
            Console.WriteLine("Dentro de cuantos segundos deseas despertar?");
            string input = Console.ReadLine();
             int segundos = int.Parse(input);
             DateTime fecha = DateTime.Now.AddSeconds(segundos);
            while (fecha > DateTime.Now)
            {
                int segundosRestantes = (int)(fecha - DateTime.Now).TotalSeconds;
                Console.WriteLine("Te despertare dentro de :" + segundosRestantes + " segundos");

            }
            AudioFileReader audioFile = new AudioFileReader("bubbling1.wav");
             WaveOutEvent outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();
            while (outputDevice.PlaybackState == PlaybackState.Playing)
            {
                //se va a ir a dormir 1 segundon 
                Thread.Sleep(1000);
            }
            // ////// liberar los recursos
            //audioFile.Dispose();
            //outputDevice.Dispose();


        }
    }
}
