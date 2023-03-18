using System;

namespace ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, cont = 1, MaiorIdade = -1;
            double renda, MenorRenda = 1000000;
            while(cont <= 1567){
                Console.Write("Digite uma idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Digite uma renda: ");
                renda = double.Parse(Console.ReadLine());
                if (idade > MaiorIdade)
                MaiorIdade = idade;
                if (renda < MenorRenda)
                MenorRenda = renda;
                cont++;
            }
            Console.WriteLine("A maior idade é: " + MaiorIdade);
            Console.WriteLine("A menor renda é: " + MenorRenda);
        }
    }
}
