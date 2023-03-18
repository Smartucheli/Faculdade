using System;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, i, pares = 0;
            for(i = 1; i <= 5; i++ ){
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());
                if( num % 2 == 0){
                    pares++;
                }
            }
            Console.WriteLine("{0} valores pares", pares);
        }
    }
}
