using System;

namespace ex008
{
    class Program
    {
        static void Main(string[] args)
        {
            int angulo1, angulo2, angulo3, soma;
            Console.WriteLine("digite 2 valores de angulos que não sejam maiores que 180: ");
            angulo1 = int.Parse(Console.ReadLine());
            angulo2 = int.Parse(Console.ReadLine());
            soma = angulo1 + angulo2;
            angulo3 = 180 - soma;
            Console.WriteLine("O terceiro angulo equivale a: " + angulo3);
        }
    }
}
