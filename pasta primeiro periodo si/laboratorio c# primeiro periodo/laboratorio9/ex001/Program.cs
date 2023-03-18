using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            int []A = new int [10];
            int []B = new int [10];
            int []C = new int [10];
            Le_vetor(A);
            Le_vetor(B);
            for(int i = 0; i < A.Length; i++){
                if(A[i] < B[i]) 
                    C[i] = A[i];
                else
                    C[i] = B[i];
            }
            for(int i = 0; i < A.Length; i++){
                Console.Write( C[i] + "\t");
            }
        }

        static void Le_vetor(int []D){
            for(int i = 0; i < D.Length; i++){
                Console.WriteLine("Digite os valores: ");
                D[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
