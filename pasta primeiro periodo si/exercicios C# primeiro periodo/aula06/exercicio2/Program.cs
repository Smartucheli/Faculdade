using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Escreva dois numeros");
            n1 = int.Parse(Console.ReadLine());
            n2 =int.Parse(Console.ReadLine());
           if(n1>n2)
           Console.WriteLine("O maior valor é: " + n1);
           else if (n2>n1)
           Console.WriteLine("O maior valor é: " + n2);
           else
           Console.WriteLine("Os valores são iguais");
        }
    }
}
