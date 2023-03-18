using System;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Digite 3 valores ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3){
                if (n2>n3){
                    Console.WriteLine(n3);
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                    Console.WriteLine(" ");
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                } else {
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                    Console.WriteLine(n1);
                    Console.WriteLine(" ");
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
            } else if(n2>n1 && n2>n3){
                if(n1>n3){
                     Console.WriteLine(n3);
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(" ");
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                } else {
                     Console.WriteLine(n1);
                    Console.WriteLine(n3);
                    Console.WriteLine(n2);
                    Console.WriteLine(" ");
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
            } else {
                if(n2>n1){
                     Console.WriteLine(n2);
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                    Console.WriteLine(" ");
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                } else {
                     Console.WriteLine(n2);
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                    Console.WriteLine(" ");
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
            }
        }
    }
}


