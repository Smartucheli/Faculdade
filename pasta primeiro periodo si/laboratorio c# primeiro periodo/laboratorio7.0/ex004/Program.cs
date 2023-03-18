using System;

namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
             double i;
            Console.WriteLine("°C \t °K");
            for(i = 0; i <= 100; i++){
            Console.WriteLine("{0} \t {1}", i, i+273.15); 
        }
    }
  }
}
