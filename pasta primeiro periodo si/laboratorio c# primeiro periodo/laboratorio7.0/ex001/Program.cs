using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
           double i;
            Console.WriteLine("°C \t °F");
            for(i = 1; i <= 100; i++){
                Console.WriteLine("{0} \t {1}", i, (i*1.8)+32); 
            }
        }
    }
}
