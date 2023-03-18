using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, fatorial = 1;
            Console.WriteLine("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());
            while (n1 > 1)
            {
                fatorial *= n1;
                n1--;
            }
            Console.WriteLine(fatorial);
        }
    }
}
