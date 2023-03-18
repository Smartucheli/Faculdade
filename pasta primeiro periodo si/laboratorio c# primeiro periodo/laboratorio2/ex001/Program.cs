using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, subtração;
            Console.WriteLine("Escreva 2 numeros, sendo que o primeiro seja maior que o segundo: ");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            subtração = numero1 - numero2;
            Console.WriteLine("A subtração desses dois numeros é de: " + subtração);

        }
    }
}
