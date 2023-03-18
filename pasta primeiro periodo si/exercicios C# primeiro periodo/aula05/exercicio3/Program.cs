using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("Escreva um valor");
            n1 = double.Parse(Console.ReadLine());
            if(n1%3==0 && n1%11==0){
                Console.WriteLine("O numero é divisivel por 3 e 11");
            } else {
                Console.WriteLine("O numero não é divisivel por 3 e 11");
            }
        }
    }
}
