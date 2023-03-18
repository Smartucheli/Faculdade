using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Digite 2 números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            if (n1>n2)
            Console.WriteLine("O menor valor é de: " + n2);
            else if(n2>n1) 
            Console.WriteLine("O menor valor é de: " + n1);
            else
            Console.WriteLine("ERROR"); 
        }
    }
}
