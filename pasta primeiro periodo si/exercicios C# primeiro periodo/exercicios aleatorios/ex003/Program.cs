using System;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            double[] ML = { 0.0, 0.0, 0.0, 0.0 };
            double[] MC = { 0.0, 0.0, 0.0, 0.0 };
            Le_matriz(matriz);
            double media = medias(matriz, ML, MC);
            int maior = 0, menor = 0;
            MaiorMenor(matriz, ref maior, ref menor);
            Console.WriteLine("medias, maior, menor");
            Imprime_Matriz(matriz, MC, ML);
        }

        static void Le_matriz(int [,]M)
        {
            for(int i = 0; i < M.GetLength(0); i++)
                for(int j =0; j < M.GetLength(1); j++){
                    Console.WriteLine("DIgite um valor: ");
                    M[i, j] = int.Parse(Console.ReadLine());
                }
        }

        static double medias(int[,] M, double[] ML, double[] MC)
        {
            double soma = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    soma += M[i, j];
                    ML[i] += M[i, j];
                    MC[j] += M[i, j];
                }
                ML[i] = ML[i] / 4;
            }
            for (int j = 0; j < 4; j++)
            {
                MC[j] = MC[j] / 4;
            }
            return soma / 16;
        }


        static void MaiorMenor(int[,] ME, ref int maior, ref int menor)
        {
            maior = menor = ME[0, 0];
            for (int i = 0; i < ME.GetLength(0); i++)
                for (int j = 0; j < ME.GetLength(1); j++)
                {
                    if (maior > ME[i, j]) maior = ME[i, j];
                    if (menor < ME[i, j]) menor = ME[i, j];
                }
        }

        static void Imprime_Matriz(int[,]M , double []ML, double []MC){
            for(int i = 0; i < 4; i++)
                for(int j = 0; j < 4; j++){
                    Console.Write(M[i,j] + "\t");
                    Console.Write(ML[i]);
                }
            for(int j = 0; j < 4; j++)
                Console.Write(MC[j] + "\t");
        }
    }


}


