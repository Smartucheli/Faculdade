using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, operacao;
            Console.WriteLine("Digite 2 valores: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Agora, escolha uma operação: ");
            Console.WriteLine("1 Adição");
            Console.WriteLine("2 Subtração");
            Console.WriteLine("3 Multiplicacao");
            Console.WriteLine("4 divisao");
            Console.WriteLine("Qual a Operação escolhida");
            operacao = int.Parse(Console.ReadLine());
            

            double result;
            if(operacao == 1) {
            result = n1+n2;
            Console.WriteLine("A adição é de: " + result);
            } else if(operacao==2){
                result = n1-n2;
                Console.WriteLine("A subtração é: " + result);
            } else if(operacao == 3){
                result = n1*n2;
                Console.WriteLine("A mutiplicação é: " + result);
            } else if (operacao == 4) {
                result = n1/n2;
                Console.WriteLine("A divisão é: " + result);
            }
        }
    }
}
