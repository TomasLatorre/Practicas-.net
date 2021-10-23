using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_practica_algoritmia
{
    class Program
    {
        static void Ejercicio1()
        {
            const int metros = 1500;
            string participante1, participante2, participante3, participante4;
            decimal vel1, vel2, vel3, vel4;

            Console.WriteLine("Ingrese el nombre del participante 1: ");
            participante1 = Console.ReadLine();
            Console.WriteLine("Ingrese el tiempo en segundos de {0}: ", participante1);
            vel1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del participante 2: ");
            participante2 = Console.ReadLine();
            Console.WriteLine("Ingrese el tiempo en segundos de {0}: ", participante2);
            vel2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del participante 3: ");
            participante3 = Console.ReadLine();
            Console.WriteLine("Ingrese el tiempo en segundos de {0}: ", participante3);
            vel3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del participante 4: ");
            participante4 = Console.ReadLine();
            Console.WriteLine("Ingrese el tiempo en segundos de {0}: ", participante4);
            vel4 = Convert.ToDecimal(Console.ReadLine());

            vel1 = Math.Round(metros / vel1);
            vel2 = Math.Round(metros / vel2);
            vel3 = Math.Round(metros / vel3);
            vel4 = Math.Round(metros / vel4);
            //double max = vel1;

            if ((vel1 > vel2) && (vel1 > vel3) && (vel1 > vel4))
            {
                Console.WriteLine($"El participante más rápido fue {participante1} con vel de {vel1} m/s");
            }
            else if ((vel2 > vel1) && (vel2 > vel3) && (vel2 > vel4))
            {
                Console.WriteLine($"El participante más rápido fue {participante2} con vel de {vel2} m/s");
            }
            else if ((vel3 > vel1) && (vel3 > vel2) && (vel3 > vel4))
            {
                Console.WriteLine($"El participante más rápido fue {participante3} con vel de {vel3} m/s");
            }
            else if ((vel4 > vel1) && (vel4 > vel2) && (vel4 > vel3))
            {
                Console.WriteLine($"El participante más rápido fue {participante4} con vel de {vel4} m/s");
            }
            else { Console.WriteLine("Hubo más de 1 ganador, pero ni idea quienes."); }
            Console.ReadKey();
            /*
            for (int i = 0;i <= 4 )
            {
                if (max > )
                {

                }
            }
            */
        }
        static void Main(string[] args)
        {
            //ejercicio 2
            int contmayores = 0;
            int cantnumeros = 0;
            int contmenores = 0;
            //int n = 0;
            Random r = new Random();
            int[] numeros = new int[50];

            //Genera un numero entre 10 y 100 (101 no se incluye)
            /*for (int i = 0; i < 50; i++)              
            {
                //numeros[i] = r.Next(-100, 200);
                n = r.Next(-100, 200);
               if (n > 100)
                {
                    cantnumeros++;
                    contmayores += n;
                }
               if (n < -10)
                {
                    contmenores += n;
                }
            }
            */
            for (int i = 0; i < 50; i++)
            {
                numeros[i] = r.Next(-100, 200);
            }

            for (int i = 0; i < 50; i++)
            {
                if (numeros[i] > 100)
                {
                    cantnumeros++;
                    contmayores = contmayores + numeros[i];
                }
            }
            for (int i = 0; i < 50; i++)
            {
                if (numeros[i] < -10)
                {
                    contmenores = contmenores + numeros[i];
                }
            }
            
            Console.WriteLine($"El promedio de los números mayores a 100 es: {contmayores/cantnumeros}");
            Console.WriteLine($"La suma de los números menores que -10 es: {contmenores}");

            Console.ReadLine();

        }
    }
}
