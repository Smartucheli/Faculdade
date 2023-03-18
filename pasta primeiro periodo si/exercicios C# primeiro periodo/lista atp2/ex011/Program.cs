using System;

namespace ex011
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double menor = 9999, p;
            for(i = 1; i <= 5; i++){
                Console.Write("Entre com um preço de gasolina:");
                p = double.Parse(Console.ReadLine());
                if(p < menor) menor = p;
            }
            Console.WriteLine("O menor preço de gasolina é {0}", menor);
        }
    }
}
