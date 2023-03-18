using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Escreva um valor");
            n1 = int.Parse(Console.ReadLine());
            if(n1%2==0){
                Console.WriteLine("O valor é par");
            } else {
                Console.WriteLine("O valor é ímpar");
            }
        }
    }
}
