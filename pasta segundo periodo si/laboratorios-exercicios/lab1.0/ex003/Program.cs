using System;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] c = new int[5];
            int[] d = new int[5];
            LeVetor(a);
            LeVetor(b);
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    c[i] = b[i];
                }
                else if (a[i] != b[i])
                {
                    d[i] = a[i];
                }
            }

            Console.Write("Os elementos em comum entre a e b são: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(c[i] + "\t");
            }

            Console.Write("Os elementos que existem em a e b são: ");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(d[i] + "\t");
            }
        }

        static void LeVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(i + 1 + "-");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
