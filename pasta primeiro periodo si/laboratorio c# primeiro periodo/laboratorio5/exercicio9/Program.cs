using System;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1, n2 = 0, soma = 0, i = 1;
            while (i <= 10)
            {
                i++;
                soma = n1 + n2;
                n2 = n1;
                n1 = soma;
                Console.WriteLine("A sequencia é: " + soma);
            }
        }
    }
}
