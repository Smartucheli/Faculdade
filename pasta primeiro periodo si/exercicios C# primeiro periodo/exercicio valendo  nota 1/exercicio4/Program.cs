using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, KmL;
            Console.WriteLine("Digite a distancia e os litros de combustivel gastos");
            X = double.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());
            KmL = X/Y;
            Console.WriteLine("{0:0.000} Km/l", KmL);
        }
    }
}
