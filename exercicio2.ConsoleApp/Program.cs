using System;

namespace exercicio2.ConsoleApp
{
    internal class Program
    {

        /*
         * Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um número");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um número");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b || b == c || a == c)
                Console.WriteLine(" Os números não são diferentes");
            else
                Console.WriteLine("");

            Console.ReadLine();
            
            
                
                 
        }
    }
}
