using System;

namespace ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, resultado = 0;
            Console.Write("Digite um numero: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            b = double.Parse(Console.ReadLine());
            resultado = potencia(ref a, ref b, resultado);
            Console.Write("A potencia de {0} na base {1} é : {2}", a, b, resultado);
        }


        static double potencia( ref double  a,  ref double b, double resultado){
            resultado = Math.Pow(a, b);
            return resultado;
        }
    }
}
