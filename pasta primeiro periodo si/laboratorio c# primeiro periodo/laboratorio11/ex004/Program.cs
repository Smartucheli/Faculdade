using System;
using System.IO;


namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoM;
            int[,] A = new int[3, 3];
            Console.WriteLine("Digite uma matriz");
            LeMatriz(A);
           
            StreamWriter sw = new StreamWriter("texto.txt");
            sw.WriteLine("Digite seu texto");
            Console.ReadLine();
            sw.Close();
            Le_arquivo(textoM);
        }

        

        static void Le_arquivo(string texto)
        {
            String text;
            StreamReader sr = new StreamReader("texto.txt");
            text = sr.ReadLine();
            while (text != null)
            {
                Console.WriteLine(text);
                texto = sr.ReadLine();
            }
            sr.Close();
        }

        static void LeMatriz(int[,] Matriz)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("[{0}, {1}] = ", i, j);
                    Matriz[i, j] = int.Parse(Console.ReadLine());
                }
        }
    }
}
