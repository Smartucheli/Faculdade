namespace ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Vet = new int[5] {30, 40, 60, 70, 90};
            int num = 30, inicio, fim;
            inicio = 0;
            fim = Vet.Length - 1;
            int resp = PesquisaBinariaREc(Vet, num, inicio, fim);
            if (resp == -1)
                Console.Write("O valor não existe");
            else 
                Console.Write("O valor esta na posição: {0}",resp);

            
            



        }

        static int PesquisaBinariaREc(int[] Vet, int pesquisa, int inicio, int fim)
        {
            int meio = (inicio + fim) / 2;
            if (inicio > fim)
            {
                return -1;
            }
            else if (Vet[meio] == pesquisa)
            {
                return meio;
            }
            else if (Vet[meio] > pesquisa)
            {
                return PesquisaBinariaREc(Vet, pesquisa, inicio, meio - 1);
            }
            else 
            {
                return PesquisaBinariaREc(Vet, pesquisa, meio + 1, fim);
            }
           
        }


    }
}