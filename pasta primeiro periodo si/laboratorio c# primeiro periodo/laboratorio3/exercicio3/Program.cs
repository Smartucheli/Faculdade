using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Escreva um numero inteiro: ");
            n1 = int.Parse(Console.ReadLine());
            if (n1 % 2 == 0)
            {
                Console.WriteLine("O valor é PAR.");
            }
            else
            {
                Console.WriteLine("O valor é IMPAR.");
            }
        }
    }
}