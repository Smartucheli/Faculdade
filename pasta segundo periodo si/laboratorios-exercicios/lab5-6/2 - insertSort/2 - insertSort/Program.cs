namespace _2___insertSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] vet = new int[5];
            //valores do vetor desordenado
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(1, 10);
            }
            imprimir(vet);

            //valores do vetor ordenado
            InsertionSort(vet);
            imprimir(vet);
        }

        private static void imprimir(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Posição: " + i + "\tValor: " + vet[i]);
            }
            Console.WriteLine();
        }

        static int[] InsertionSort(int[] vet)
        {
            int aux;
            for (int i = 0; i < vet.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (vet[j - 1] > vet[j])
                    {
                        aux = vet[j - 1];
                        vet[j - 1] = vet[j];
                        vet[j] = aux;
                    }
                }
            }
            return vet;
        }
    }
}
