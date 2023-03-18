using System.Reflection;

namespace ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5] { 7, 8, 1, 2, 9 };
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i]);
            }


            

            
            for(int i = 0; i < vet.Length; i++)
            {
                OrdenaçãoBinaria(vet, 0, vet.Length - 1);
                Console.Write(vet[i]);
            }
        }



        static void OrdenaçãoBinaria(int[] vet, int inicio, int fim)
        {

            if (inicio < fim)
            {
                int meio = (inicio + fim) / 2;
                OrdenaçãoBinaria(vet, inicio, meio);
                OrdenaçãoBinaria(vet, meio + 1, fim);
                merge(vet, inicio, (meio + 1), fim);
            }
        }


        static void merge(int[] vet, int inicio, int fim, int meio)
        {
            
            int[] aux = new int[vet.Length];
            for (int s = inicio; s <= fim; s++)
            {
                aux[s] = vet[s];
            }


            int i = inicio;
            int j = meio + 1;
            int k = fim;

            while (i <= meio && j <= fim)
            {

                if (aux[i] <= aux[j])
                {
                    vet[k] = aux[i];
                    i++;
                }
                else
                {
                    vet[k] = aux[j];
                    j++;
                }
                k++;

            }


          


            
        }
    }
}