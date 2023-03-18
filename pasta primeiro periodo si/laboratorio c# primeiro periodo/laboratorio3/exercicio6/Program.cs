using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Digite 3 números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            if(n1>n2 && n1>n3){
                Console.WriteLine("O maior número " + n1);
            } else if(n2>n1 && n2>n3){
                Console.WriteLine("O maior número " + n2);
            } else {
                Console.WriteLine("O maior número " + n3);
            }
            if(n1<n3 && n1<n2){
                Console.WriteLine("O menor número " + n1);
            } else if(n2<n1 && n2<n3){
                Console.WriteLine("O menor número " + n2);
            } else{
                Console.WriteLine("O menor numero " + n3);
            }
        }
    }
}
