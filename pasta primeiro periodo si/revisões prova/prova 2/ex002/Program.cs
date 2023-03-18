using System;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] VetorA = new int[100];
            int[] VetorB = new int[100];
            int[] VetorC = new int[100];
            Le_vetor(VetorA);
            Le_vetor(VetorB);
            for(i = 0; i < VetorA.Length; i++){
                if(VetorA[i] > VetorB[i])
                    VetorC[i] = VetorA[i];
                else
                    VetorC[i] = VetorB[i];

            Console.WriteLine(VetorC[i] + "\t");
            }

        }


        static void Le_vetor(int[] vet)
        {
            int i;
            for (i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Digite um valor: ");
                vet[i] = int.Parse(Console.ReadLine());
            }
        }

    }
}
