using System;
using System.IO;

namespace ex002
{
    class Program
    {
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
                sr.Close();
        }
    }
}
