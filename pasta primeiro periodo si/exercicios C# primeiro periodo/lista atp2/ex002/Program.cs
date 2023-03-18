using System;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, positivos = 0;
            double num, soma = 0, media;
            while(i <= 6){
                Console.Write("Digite um número: ");
                num = double.Parse(Console.ReadLine());
                if(num > 0){
                    positivos++;
                    soma += num;
                }
                i++;
            }
            media = soma / positivos;
            Console.WriteLine("{0} valores positivos", positivos);
            Console.WriteLine("{0:0.0}", media); 
            
        }
    }
}
