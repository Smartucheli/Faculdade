using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta, raiz1, raiz2;
            Console.WriteLine("Digite os valores A, B, C");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            delta =(B * B) - (4* A * C);
            if(A==0 || delta < 0){
            Console.WriteLine("Impossivel calcular");
            } else {
            raiz1 = ((-B) + Math.Sqrt(delta)) / (2*A);
            raiz2 = ((-B) - Math.Sqrt(delta)) / (2*A);
            Console.WriteLine(raiz1+"," + raiz2);
            }
        }
    }
}
