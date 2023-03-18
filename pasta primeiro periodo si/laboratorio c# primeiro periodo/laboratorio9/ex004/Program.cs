using System;

namespace ex004
{
    class Program
    {
        const int TAM = 120;
        static void Main(string[] args)
        {
        int i;
        int []letras = new int [TAM];
        char p;
        string texto;

        Console.Write("Entre com um texo: ");
        texto = Console.ReadLine();
            for(i = 0; i < TAM; i++)
                letras[i] = 0;
            for(i = 0; i < texto.Length; i++)
                letras[texto[i]]++;
           for(p = (char)0; p < TAM; p++)
               if(letras[p] != 0)
                    Console.WriteLine("O caracter" + p + "apareceu" + letras[p] + "vezes");
        }
    }
}
