namespace _4___MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] vet = new int[5];
            //adiciona numeros aleatorios ao vetor e imprime
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(1, 10);
            }
            imprime(vet);

            int inicio = vet[0];
            int fim = vet.Length - 1;
            //ordena e impre o vetor
            mergesort(vet, inicio, fim);
            imprime(vet);
        }

        private static void mergesort(int[] vet, int inicio, int fim)
        {
            int meio;
            if (fim > inicio)
            {
                meio = (inicio + fim) / 2;
                mergesort(vet, inicio, meio);
                mergesort(vet, meio + 1, fim);
                Merge(vet, inicio, meio + 1, fim);

            }
        }

        private static void imprime(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Posição: " + i + "\tVetor: " + vet[i]);
            }
            Console.WriteLine();
        }

        static void Merge(int[] vet, int inicio, int meio, int fim)
        {
            int[] aux = new int[vet.Length];
            int temp, tam, j;
            tam = meio - 1;
            temp = inicio;
            j = fim - inicio + 1;


            while (inicio <= tam && meio <= fim)
            {
                if (vet[inicio] <= vet[meio])
                {
                    aux[temp++] = vet[inicio++];
                }
                else
                {
                    aux[temp++] = vet[meio++];
                }
            }

            while (inicio <= tam)
            {
                aux[temp++] = vet[meio++];
            }

            while (meio <= fim)
            {
                aux[temp++] = vet[meio++];
            }

            for (int i = 0; i < j; i++)
            {
                vet[fim] = aux[fim];
                fim--;
            }
        }
    }
}
