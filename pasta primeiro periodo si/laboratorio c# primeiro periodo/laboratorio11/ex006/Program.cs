using System;
using System.IO;


namespace ex006
{
    class Program
    {

        const int TAM = 256;
        static void Main(string[] args)
        {
            String texto;
            StreamReader sr = new StreamReader("texto.txt");
            texto = sr.ReadLine();
            while (texto != null)
            {
                Console.WriteLine(texto);
                texto = sr.ReadLine();
            }
            int[] letras = new int[TAM];
            char c;

            Console.Write("Entre com o texto:");
            texto = Console.ReadLine();
            for (int i = 0; i < TAM; i++) letras[i] = 0;
            for (int i = 0; i < texto.Length; i++) letras[texto[i]]++;
            for (c = (char)0; c < TAM; c++)
                if (letras[c] != 0)
                    Console.WriteLine("O caracter " + c + " apareceu " + letras[c] + " vezes");
            sr.Close();
        }
    }
}

