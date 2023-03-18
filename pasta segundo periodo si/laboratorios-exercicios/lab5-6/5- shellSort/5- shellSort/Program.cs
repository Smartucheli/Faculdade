namespace _5__shellSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] vet = new int[5];
            int[] intervalos = new int[3] { 1, 2, 3 };
            //preenche o vetor e imprime
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(1, 10);
            }
            imprime(vet);

            //ordena e imprime o vetor
            ShellSort(vet, intervalos);
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

        static void ShellSort(int[] vet, int[] pos)
        {
            int i, j, k, m;
            int N = vet.Length;

            for (k = pos.Length - 1; k >= 0; k--)
            {
                int intervalo = pos[k];
                for (m = 0; m < intervalo; m++)
                {
                    for (j = m + intervalo; j < N; j += intervalo)
                    {
                        for (i = j; i >= intervalo && vet[i] < vet[i - intervalo]; i -= intervalo)
                        {
                            Trocavalor(vet, i, i - intervalo);
                        }
                    }
                }
            }

        }

        private static int[] Trocavalor(int[] vet, int i, int v)
        {
            int aux;
            aux = vet[i];
            vet[i] = vet[v];
            vet[v] = aux;
            return vet;

        }
    }
}
