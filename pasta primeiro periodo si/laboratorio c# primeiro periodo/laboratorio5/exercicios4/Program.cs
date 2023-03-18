using System;

namespace exercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, cont = 1;
            Console.WriteLine("Digite um número positivo: ");
            n1 = int.Parse(Console.ReadLine());
            while(cont <= n1){
                cont++;
                if(n1 % cont == 0){
                    Console.WriteLine(cont);
                }
            }
        }
    }
}
