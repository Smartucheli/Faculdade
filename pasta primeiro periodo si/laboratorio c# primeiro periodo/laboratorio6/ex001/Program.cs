using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1, soma = 0;
            while (n1 != 0)
            {
                Console.Write("Digite um valor: ");
                n1 = int.Parse(Console.ReadLine());
                soma += n1;
            }
            Console.WriteLine("A soma é dos valores: " + soma);
        }
    }
}
