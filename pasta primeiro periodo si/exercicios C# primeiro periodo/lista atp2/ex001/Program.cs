using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, positivos = 0;
            double num;
            while(i <= 6){
                Console.WriteLine("Digite um número: ");
                num = double.Parse(Console.ReadLine());
                if(num > 0){
                    positivos++;
                }
                i++;
            }
            Console.WriteLine("{0} valores positivos", positivos);
        }
    }
}
