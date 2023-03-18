using System;

namespace ex005
{
    class Program
    {
         static void Main(string[] args)
        {
            int [,]M1 = new int [4,4];
            int[,]M2 = new int[4,4];
            int[,]M3 = new int [4,4];
            Le_Vetor(M1);
            Le_Vetor(M2);
            Soma(M1, M2, M3);
            Console.WriteLine("O vetor 3 tem o resultado: ");
            for(int i = 0; i < 4; i++){ 
                for(int j = 0; j < 4; j++)
                Console.Write(M3[i, j] + "\t");
                Console.WriteLine();
        }
        Console.WriteLine("A diagonal principal é: {0} e a secundaria é: {1}", SomaDiagonalP(M3), SomaDiagonalSc(M3));
    }

        static void Le_Vetor(int [,]A){
            for(int i = 0; i < A.GetLength(0); i++)
                for(int j = 0; j < A.GetLength(1); j++){
                    Console.WriteLine("Digite valores: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
        }

        static void Soma(int [,]B, int[,]C, int[,]D){
            for(int i = 0; i < B.GetLength(0); i++)
                for(int j = 0; j < B.GetLength(1); j++)
                    D[i,j] = B[i,j] + C[i, j];
        }

        static int SomaDiagonalP(int[,]M){
            int soma = 0;
            for(int i = 0; i < M.GetLength(0); i++)
                soma += M[i, i];
            return soma;
        }

        static int SomaDiagonalSc(int[,]M){
            int soma = 0;
            for(int i = 0; i < M.GetLength(0); i++)
                soma += M[i, M.GetLength(0)];
            return soma;
        }
    }
}