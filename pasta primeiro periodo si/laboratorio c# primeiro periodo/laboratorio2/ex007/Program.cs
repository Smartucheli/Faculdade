using System;

namespace ex007
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, comprimento, area, volume;
            Console.WriteLine("Escrava um valor de raio e o programa mostrara qual o comprimento, area e volume: ");
            raio = double.Parse(Console.ReadLine());
            comprimento = 2*Math.PI*raio;
            area = Math.PI*Math.Pow(raio, 2);
            volume = 4/3*Math.PI*Math.Pow(raio, 3);
            Console.WriteLine("O comprimeto é: " + comprimento);
            Console.WriteLine("A area é: " + area);
            Console.WriteLine("O volume é: " + volume);
        }
    }
}
