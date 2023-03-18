using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            
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

        static void Le_matriz(int [,]M) {
            for(int i = 0; i < M.GetLength(0); i++)
                for(int j = 0; j < M.GetLength(1); j++){
                    Console.WriteLine("Digite um valor: ");
                    M[i, j] = int.Parse(Console.ReadLine());
                }

        }
    }
}
