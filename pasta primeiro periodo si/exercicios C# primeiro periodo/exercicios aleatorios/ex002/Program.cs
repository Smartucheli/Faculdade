using System;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[20], B = new int[20];
            int i;
            LeVetor(A);
            LeVetor(B);
            for(i = 0; i < 20)
        }

        static void LeVetor(int []vet){
            int i;
            for(i = 0; i < 20; i++ ){
                Console.WriteLine("Digite um valor");
                vet[i] = int.Parse(Console.ReadLine());

            }
        }
    }
}
