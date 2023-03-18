using System;

namespace ex009
{
    class Program
    {
        static void Main(string[] args)
        {
          int[,] M1 = new int[4, 4];
            int[,] M2 = new int[4, 4];
            int[,] M3 = new int[4, 4];
            Le_Vetor(M1);
            Console.WriteLine("O vetor tem o resultado: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++){
                    if(j >= i)
                        Console.Write(M1[i , j] + "\t");
                    else{
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            
        }

        static void Le_Vetor(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.WriteLine("Digite valores: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }  
        }
    }
}
