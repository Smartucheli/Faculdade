using System;

namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1, n2;
           Console.WriteLine("Digite dois números: ");
           n1 = int.Parse(Console.ReadLine());
           n2 = int.Parse(Console.ReadLine());
           while(n2 >= n1){
               if(n1 % 3 == 0)
               Console.Write(n1 + "\t");
               n1++;
           }
        }
    }
}
