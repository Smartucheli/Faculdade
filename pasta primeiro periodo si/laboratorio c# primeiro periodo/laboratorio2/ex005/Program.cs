using System;

namespace ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            double SalarioMinimo, SalarioFuncionario, QuantidadeSalario;
            Console.WriteLine("digite o valor do salario minimo e do salario de um funcionario: ");
            SalarioMinimo = double.Parse(Console.ReadLine());
            SalarioFuncionario = double.Parse(Console.ReadLine());
            QuantidadeSalario = SalarioFuncionario/SalarioMinimo;
            Console.WriteLine("A quantidade de salarios minimos que esse funcionario tem é de: " + QuantidadeSalario);
        }
    }
}
