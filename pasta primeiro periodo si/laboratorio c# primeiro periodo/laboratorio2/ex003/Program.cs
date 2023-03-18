using System;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco1, desconto, NovoValor;
            Console.WriteLine("Digite o valor do produto: ");
            preco1 = double.Parse(Console.ReadLine());
            desconto = preco1*0.1;
            NovoValor = preco1 - desconto;
            Console.WriteLine("O desconto em cima do produto é de: " + NovoValor);
        }
    }
}
