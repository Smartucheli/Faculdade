using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, cont = 1, soma = 0;
            while (cont <= 10)
            {
                Console.Write("escreva 10 números: ");
                n1 = int.Parse(Console.ReadLine());
                cont++;
                soma += n1;
            }
            Console.WriteLine("A soma é {0}", soma);
        }
    }
}
