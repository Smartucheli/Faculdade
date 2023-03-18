using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, cont;
            Console.WriteLine("Digite 2 números");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            cont = n1;
            while(cont <= n2){
                Console.WriteLine(cont);
                cont++;
            }
            }
        }
    }

