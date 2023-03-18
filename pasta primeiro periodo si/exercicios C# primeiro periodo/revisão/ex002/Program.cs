using System;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, cont = 1, soma = 0;
            while(cont <= 10){
                Console.Write("digite 10 numeros: ");
                n1 = double.Parse(Console.ReadLine());
                soma += n1;
                cont++;
            }
            Console.WriteLine("A media é: " + (soma/10));

            }
        }
    }

