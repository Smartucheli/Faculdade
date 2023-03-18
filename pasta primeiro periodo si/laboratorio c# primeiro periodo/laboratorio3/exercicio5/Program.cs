using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Digite um numero: ");
            n1 = int.Parse(Console.ReadLine());
            if(n1%2 ==0 && n1%7==0) {
                Console.WriteLine("O numero é divisivel por 2 e 7 ao mesmo tempo.");
            } else{
                Console.WriteLine("O numero não é divisivel por 2 e 7 ao mesmo tempo.");
            }
        }
    }
}
