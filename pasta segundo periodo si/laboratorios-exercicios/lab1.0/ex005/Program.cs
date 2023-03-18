using System;

namespace ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Digite um valor e sera exibido seu fatorial: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("O valor de {0} fatorial é de: {1}", N, Fat(N));
        }


        static int Fat(int num){
            if(num == 2){
                return 2;
            } else {
                return num * Fat(num - 1);
            }
        }
    }
}
