using System;
using System.IO;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("poema.txt");
            sw.WriteLine("Digite seu poema");
            Console.ReadLine();
            sw.Close();
        }

    }
}

