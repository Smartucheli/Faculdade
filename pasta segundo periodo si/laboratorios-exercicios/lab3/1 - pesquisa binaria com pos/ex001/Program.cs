namespace ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Vetor = new int[] { 1, 2, 3, 4, 5 };
            int pos = 0;
            int valor = 4;
            Console.WriteLine("Pesquisa binaria para achar a posição do valor 4");
            pos = PesquisaBInaria(Vetor, valor);
            if( pos == -1)
            {
                Console.Write("O valor não pode ser encontrado ");
            } else
            {
                Console.WriteLine("O valor encontrado esta na posição: {0}", pos);
            }

        }

        static int PesquisaBInaria(int []Vet, int valor)
        {
            int meio, inicio, fim;
            inicio = 0;
            fim = Vet.Length - 1;
            int p = -1;
            do
            {
                meio = (int)(inicio + fim) / 2;

                if (Vet[meio] == valor)
                {
                    p = meio;
                    break;
                }
                else if (Vet[meio] < valor)
                {
                    inicio = meio + 1;
                }
                else
                {
                    fim = meio - 1;
                }
            } while (inicio <= fim);
                 return p;
            
        }
    }
}