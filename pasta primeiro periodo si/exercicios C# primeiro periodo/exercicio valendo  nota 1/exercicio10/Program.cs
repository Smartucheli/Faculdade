using System;

namespace exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Digite 2 valores");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            if (n1 % n2 == 0 || n2 % n1 == 0){
                Console.WriteLine("Sâo multiplos");
            } else {
                Console.WriteLine("Não são multiplos");
            }
        }
    }
}
