using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, media;
            Console.WriteLine("Digite um número e uma média: ");
            n1 = int.Parse(Console.ReadLine());
            media = int.Parse(Console.ReadLine());
            if(n1>media)
            Console.WriteLine("o Numero digitado esta acima da media. ");
            else if(media>n1)
            Console.WriteLine("o valor digitado esta abaixo da media.");
            else
            Console.WriteLine("O valor digitado esta em cima da media.");
        }
    }
}
