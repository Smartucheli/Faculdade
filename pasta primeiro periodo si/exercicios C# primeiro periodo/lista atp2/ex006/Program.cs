using System;

namespace ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, conta = 0;
            Console.WriteLine("Digite um valor: ");
            n = int.Parse(Console.ReadLine());
            
            for(i = 1; i <= n; ++i){
                if(i % 2 == 0){
                    conta = i*i;
                    Console.WriteLine("{0}^2 = {1}", i, conta);
                }
            }
        }
    }
}
