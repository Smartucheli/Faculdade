using System;

namespace ex008
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            do{
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if(x > y){
                Console.WriteLine("Decrescente");
            } else if(x < y){
                Console.WriteLine("Crescente");
            }
        } while(x != y);{
                
        }
    }
}
}