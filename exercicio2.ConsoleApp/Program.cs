using System;
using System.Linq;

namespace exercicio2.ConsoleApp
{
    internal class Program
    {

        /*
         * Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b || b == c || a == c)
                Console.WriteLine("Os números não são diferentes");
            else
            {
                int[] listaValoresEntrada = { a, b, c };
                listaValoresEntrada = listaValoresEntrada.OrderByDescending(c => c).ToArray();

                Console.WriteLine("A lista de números em ordem decrescente é: ");

                foreach (int value in listaValoresEntrada)
                {
                    Console.Write(value + " ");
                }
            }                        
            Console.ReadLine();
        }
    }
}
