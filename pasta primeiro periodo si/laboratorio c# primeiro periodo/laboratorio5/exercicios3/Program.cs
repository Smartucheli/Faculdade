using System;

namespace exercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, cont;
            Console.WriteLine("Digite dois números");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            cont = n1;
             
            if (n2 > n1){
                n1 = cont;
                while(cont <= n2){
                    cont++;
                    if(cont % 3 == 0){
                        Console.WriteLine(cont);
                    }
                }
            } 
            cont = n2;
            if(n1 > n2){
                n2 = cont;
            }  while(cont <= n1){
                cont++;
                if(cont % 3 == 0){
                    Console.WriteLine(cont);
                }
            }
            
            
        }
    }
}

