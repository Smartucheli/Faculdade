using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Escreva dois numero: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            if(n1>n2) {
                Console.WriteLine("O numero maior é o: " + n1);
            } else {
                Console.WriteLine("O maior numero é o: " + n2);
            }
        }
    }
}
