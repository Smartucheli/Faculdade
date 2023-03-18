using System;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, soma = 0;
            if (n1 < 13){
                while (soma < 21){
                    Console.WriteLine("Digite um número: ");
                    n1 = int.Parse(Console.ReadLine());
                    soma += n1;
                }
            }
            if(soma == 21){
            Console.WriteLine("Parabens voce ganhou!");
            }else if(soma > 21){
            Console.WriteLine("Tente novamente, voce perdeu!");
            }
        }
    }
}
