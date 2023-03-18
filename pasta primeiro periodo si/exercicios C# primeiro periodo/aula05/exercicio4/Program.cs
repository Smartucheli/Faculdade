using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3;
            Console.WriteLine("Digite 3 números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            if (n1>n2 && n1>n3)
            Console.WriteLine("O maior numero é: " + n1);
            else if (n2>n1 && n2>n3)
            Console.WriteLine("O maior número é: " + n2);
            else
            Console.WriteLine("O maior numero é: " + n3);
        }
    }
}
