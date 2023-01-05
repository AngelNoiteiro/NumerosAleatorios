// Simple gerador de números aleatorios

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numeroSinCotaArbitraria = rnd.Next();
            Console.WriteLine("Número sem cotas: {0}", numeroSinCotaArbitraria);
            int numeroConCotaSuperior = rnd.Next(5);
            Console.WriteLine("Número entre 0 e 5: {0}", numeroConCotaSuperior);
            int numeroConDosCotas = rnd.Next(4, 10);
            Console.WriteLine("Número entre 4 e 10: {0}", numeroConDosCotas);
        }
    }
}
