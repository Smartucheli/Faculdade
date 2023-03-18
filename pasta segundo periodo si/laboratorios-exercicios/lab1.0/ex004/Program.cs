using System;

namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
        int soma;
        int[,] a = new int[5,3];
        LeMatriz(a);
        int[] SmL = new int[5];
        int[] SmC = new int[5];

        for (int l = 0; l < 5; l++)
        {
            soma = 0;
            for(int c = 0; c < 3; c++)
            {
                soma += a[l, c];
            }
            SmL[l] = soma;   
        }

        for(int c = 0; c < 3; c++)
        {
            soma = 0;
            for(int l = 0; l < 5; l++)
            {
                soma += a[l, c];
            }
            SmC[c] = soma;
        }

        for (int l = 0; l < 5; l++)
        {
            Console.WriteLine("\nLinha: {0} \tSoma da Linha: {1}",l, SmL[l]);
        }

        for (int c = 0; c < 3; c++)
        {
            Console.WriteLine("\nColuna: {0} \tSoma da Coluna: {1}", c, SmC[c]);
        }
        }

        static void LeMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Coluna{0} \tLinha{1} :", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
