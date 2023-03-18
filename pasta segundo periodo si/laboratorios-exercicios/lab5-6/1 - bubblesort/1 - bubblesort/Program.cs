namespace _1___bubblesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] vet = new int[5];
            //Prenche com valores randomicos e imprime 
            Console.WriteLine("Vetor desordenado");
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(1, 10);
            }
            impremir(vet);

            //ordena e impreme
            Console.WriteLine("Vetor ordenado");
            BubbleSort(vet);
            impremir(vet);
        }

        private static void impremir(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("posição: " + i + "\tvalor: " + vet[i]);
            }
            Console.WriteLine();
        }

        static void BubbleSort(int[] numeros)
        {
            int aux;
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }

        }
    }
}
