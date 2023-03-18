using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
        int codigo, quantidade;
        Console.WriteLine("Digite um código do cardapio");
        codigo = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade");
        quantidade = int.Parse(Console.ReadLine());
        double conta;
        if(codigo == 1){
            conta = 4.00*quantidade;
        } else if(codigo == 2){
            conta = 4.5*quantidade;
            Console.WriteLine(conta);
        } else if(codigo == 3){
            conta = 5.00*quantidade;
            Console.WriteLine(conta);
        } else if (codigo == 4){
            conta = 2.00*quantidade;
            Console.WriteLine(conta);
        } else if (codigo == 5){
            conta = 1.50*quantidade;
            Console.WriteLine(conta);
        }
        }
    }
}
