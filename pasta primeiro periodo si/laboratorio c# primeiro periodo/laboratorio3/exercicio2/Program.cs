using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1;
            Console.WriteLine("Escreva um numero: ");
            n1 = int.Parse(Console.ReadLine());
            if(n1>0){
                Console.WriteLine("O número digitado é positvo");
            } else if (n1<0) {
                Console.WriteLine("O número digitado é negativo");
            } else {
                Console.WriteLine("O número digitado é nulo");
            }
        }
    }
} 
