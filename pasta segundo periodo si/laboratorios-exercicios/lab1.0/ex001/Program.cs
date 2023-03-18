using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            int contA = 0, contS = 0;
            int a, divnum = 0, resto = 0, soma = 0, quadrado = 0;
            Console.Write("Digite um numero: ");
            a = int.Parse(Console.ReadLine());
            contA++;
            divnum = a / 100;
            contA++;
            resto = a % 100;
            contA++;
            soma = divnum + resto;
            contS++;
            quadrado = soma * soma;
            contA++;
            Console.WriteLine("A soma de {0} com {1} é igual a {2}", divnum, resto, soma);
            Console.WriteLine("E o quadrado é {0}", quadrado);
            Console.WriteLine(contS);
            Console.WriteLine(contA);
        }
    }
}
