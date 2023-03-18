using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1, cont;
            cont = n1;
            while(cont < 1000){
                cont++;
                if(cont % 7 == 0)
                Console.WriteLine(cont);
            }
            }
        }
    }

