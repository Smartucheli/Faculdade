using System;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
              double i, conta = 0, n;
            Console.WriteLine("Digite um valor: ");
            n = double.Parse(Console.ReadLine());
            for(i = 1; i <= n; i++){
                conta = conta + 1/i;
            }
            Console.WriteLine("s = {0}", conta);
        }
    }
}
