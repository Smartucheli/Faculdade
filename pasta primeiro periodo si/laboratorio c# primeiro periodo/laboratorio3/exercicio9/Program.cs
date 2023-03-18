using System;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            double HorasTrabalhadas, SalarioHora, SalarioBruto;
            Console.WriteLine("Digite as horas trabalhadas");
            HorasTrabalhadas = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o salário por hora");
            SalarioHora = double.Parse(Console.ReadLine());
            SalarioBruto = HorasTrabalhadas*SalarioHora;
            double SalarioLiquido;
            if(SalarioBruto<350){
                Console.WriteLine("O salário líquido é igual a = " + SalarioBruto);
            } else if (SalarioBruto>=350 && SalarioBruto<=1000){
                SalarioLiquido = SalarioBruto*(0.9);
                Console.WriteLine("O salário líquido é igual = " + SalarioLiquido);
            } else {
                SalarioLiquido = SalarioBruto*(0.8);
                Console.WriteLine("O salário líquido é igual = " + SalarioLiquido);
            }
        }
    }
}
