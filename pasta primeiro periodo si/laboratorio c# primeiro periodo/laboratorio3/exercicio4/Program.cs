using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Digite um valor: ");
            n1 = int.Parse(Console.ReadLine());
            if(n1<0) {
                n1 *= -1;
                Console.WriteLine("O valor absoluto é de: " + n1);

            } else {
                Console.WriteLine("O valor absoluto é de:" + n1);
            }
        }
    }
}
