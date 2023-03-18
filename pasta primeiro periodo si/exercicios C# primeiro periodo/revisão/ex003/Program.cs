using System;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, cont;
            Console.WriteLine("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());
            cont = n1;
            while(cont >= 1){
                if(cont % 2 == 1){
                    Console.WriteLine(cont + "\t");
                    cont--;
                }
            }
        }
    }
}
