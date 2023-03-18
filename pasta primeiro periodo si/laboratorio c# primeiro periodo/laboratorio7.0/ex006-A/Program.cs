using System;

namespace ex006_A
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, n = 1, soma = 0;
            for(i = 1, n = 1; i <= 50; i++, n+=2  ){
                soma = soma+n/i;
            }
            Console.Write(soma);
        }
    }
}
