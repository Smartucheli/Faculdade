using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, n = 3.14159, raio;
            Console.WriteLine("Digite o valor do raio");
            raio = double.Parse(Console.ReadLine());
            area = (raio * raio) * n;
            Console.WriteLine(area);
        }
    }
}
