using System;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,]A = new int [4, 4];
            int [,]B = new int [4, 4];
            Console.WriteLine("O maior valor da primeira matriz é: {0}", Maior(A));
            Console.WriteLine("O maior valor da segunda matriz é: {0}",  Maior(B));
        }

        static int Maior(int [,]M){
            int maior = 0;
            for(int i = 0; i < 4; i++)
                for(int j = 0; j < 4; j++){
                    maior = M[0, 0];
                {
                    if (maior > M[i, j]) maior = M[i, j];  
                }
        }
        return maior;
    }
}
}

