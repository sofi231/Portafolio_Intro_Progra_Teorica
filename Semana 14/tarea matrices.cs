using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores_pt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] notas = new double[5, 6];
            string[] nombres = new string[5];
            double[] promedio = new double[5];

            for (int f = 0; f < 5; f++){
                Console.WriteLine("Ingrese nombre ");
                nombres[f] = Console.ReadLine();
                
                for (int c = 0; c < 6; c++)
                {
                    Random r = new Random();
                    notas[f, c] = r.Next(1, 100); 
                }
            }
            
            for (int f = 0; f < 5; ++f)
            {
                Console.Write(nombres[f] + " ");
                for (int c = 0; c < 6; c++)
                {
                    Console.Write(notas[f,c]+ " - ");
                }
                Console.WriteLine();
            }
            
            for (int f = 0; f < 5; f++)
            {
                 double suma = 0;
                 for (int c = 0; c < 6; c++)
             {
                     suma += notas[f, c];
              }
              
            promedio[f] = suma / 6;
            Console.WriteLine("Promedio de " + nombres[f] + ": " + promedio[f]);
        }
            Console.ReadKey();
        }
    }
}
