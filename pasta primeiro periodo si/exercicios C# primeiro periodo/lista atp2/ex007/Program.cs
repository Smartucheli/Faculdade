using System;

namespace ex007
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1;
            Console.Write("Digite um valor: ");
            n = int.Parse(Console.ReadLine());
            while(i <= 10){
                Console.WriteLine("{0} x {1} = {2}", i, n, i*n);
                i++;
            }
        }
    }
}
