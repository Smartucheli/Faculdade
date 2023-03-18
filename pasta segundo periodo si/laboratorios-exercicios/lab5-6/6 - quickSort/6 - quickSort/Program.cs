namespace _6___quickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] vet = new int[5];
            //preenche e imprime os valores do vetor
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(1, 10);
            }
            imprime(vet);

            //ordena e imprime o vetor
            Quicksort(vet);
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

        static int[] Quicksort(int[] vet)
        {
            int inicio = 0, fim = vet.Length - 1;
            sort(vet, inicio, fim);
            return vet;
        }

        private static void sort(int[] vet, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = vet[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)
                {
                    if (vet[i] <= p)
                    {
                        i++;
                    }
                    else if (p < vet[f])
                    {
                        f--;
                    }
                    else
                    {
                        troca(vet, i, f);
                    }
                }
                vet[inicio] = vet[f];
                vet[f] = p;

                sort(vet, inicio, f - 1);
                sort(vet, f + 1, fim);
            }
        }

        private static int[] troca(int[] vet, int i, int j)
        {
            int aux = vet[i];
            vet[i] = vet[j];
            vet[j] = aux;
            return vet;



        }
    }
}
