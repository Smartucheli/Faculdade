using System;

namespace ex002._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 1, quantidade = 1000, soma = 0, j;

        while (valor <= quantidade)
        {
            for (j = 1; j < valor; j++)
            {
                if (valor % j == 0)
                {
                    soma = soma + j;
                }
            }

            j = 0;

            if (soma == valor)
            {
                Console.WriteLine("Números Perfeitos: {0}", valor );
            }
            soma = 0;
            valor++;
        }
    }
        }
    }

