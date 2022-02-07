using System;

namespace exercicio4.ConsoleApp
{
    internal class Program
    {
        //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int numero = Convert.ToInt32(Console.ReadLine());

            if ((numero % 2) == 0)
                Console.WriteLine("O número que você digitou é par");
            else
                Console.WriteLine("O número que você digitou é ímpar");

            Console.ReadLine();
        }
    }
}
