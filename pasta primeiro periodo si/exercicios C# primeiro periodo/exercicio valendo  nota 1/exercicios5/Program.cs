using System;

namespace exercicios5
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia, Tempo;
            Console.WriteLine("Digite uma distancia: ");
            distancia = int.Parse(Console.ReadLine());
            Tempo = distancia*2;
            Console.WriteLine("{0:0} minutos", Tempo );

        }
    }
}
