using System;

class Exercicio02
{

    // função faz um InsertionSort na ordem crescente.
    static public int[] ordena_livro(int[] vet)
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


    //Função que imprime os valores do vetor
    public static void imprimir(int[] vet)
    {
        for (int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine("Livro: " + i + "\tAno: " + vet[i]);
        }
        Console.WriteLine();
    }
}