using System;
using System.IO;


namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto;
                StreamReader sr = new StreamReader("texto.txt");
                texto = sr.ReadLine();
                for (int i = 0; texto != null; i++)
                {
                    Console.WriteLine(texto);
                    texto = sr.ReadLine();
                }
                sr.Close();
        }
    }
}
