using System;

namespace ex010
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            n = int.Parse(Console.ReadLine());
            for(i = 1; i<=n*4 ; i+=4){
                Console.WriteLine("{0} {1} {2} PUM", i, i+1, i+2 );
            }
        }
    }
}
