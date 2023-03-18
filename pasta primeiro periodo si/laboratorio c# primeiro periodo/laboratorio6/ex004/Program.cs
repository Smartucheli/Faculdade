using System;

namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1, soma = 0, i = 0;
            char repetir;
            do 
            {
               
                while(n1 != 0){
                Console.Write("Digite um valor: ");
                n1 = int.Parse(Console.ReadLine());
                soma += n1;
                i++;
                }
            Console.WriteLine("A soma é dos valores: " + soma);
            Console.WriteLine("A quantidade de valores digitados é {0} ", i);
            Console.WriteLine("\n deseja refazer seu programa? (S/N)");
            repetir = Console.ReadKey().KeyChar;
        } while(repetir == 's' || repetir == 'S');
        }
    }
}
