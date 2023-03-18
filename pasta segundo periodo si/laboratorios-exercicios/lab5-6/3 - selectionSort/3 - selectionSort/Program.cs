namespace _3___selectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] vet = new int[5];
            // adiciona valores ao vetor e imprime
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(1, 10);
            }
            imprime(vet);

            //Ordena e imprime o vetor
            SelectionSort(vet);
            imprime(vet);

        }

        private static void imprime(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Posição: " + i + "\tValor: " + vet[i]);
            }
            Console.WriteLine();
        }

        static void SelectionSort(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                int menor = i;
                for (int j = i + 1; j < vet.Length; j++)
                {
                    if (vet[j] < vet[menor])
                    {
                        menor = j;
                    }
                }
                trocar(vet, i, menor);
            }
        }

        private static void trocar(int[] vet, int i, int menor)
        {
            int aux = vet[i];
            vet[i] = vet[menor];
            vet[menor] = aux;
        }
    }
}
