using System;

namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,]M1 = new int [4,4];
            int [,]M2 = new int [4,4];
            Le_Vetor(M1);
            Le_Vetor(M2);
            Console.WriteLine("As medias são : {0} e {1}", Media(M1), Media(M2));
                
        }

        static void Le_Vetor(int [,]A){
            for(int i = 0; i < A.GetLength(0); i++)
                for(int j = 0; j < A.GetLength(1); j++){
                    Console.WriteLine("Digite valores: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
        }

        static double Media(int [,]M){
            double soma = 0;
            for(int i = 0; i < 4; i++)
                for(int j = 0; j < 4; j++){
                    soma += M[i, j];
                }
            return soma/16;
        }
    }
}
