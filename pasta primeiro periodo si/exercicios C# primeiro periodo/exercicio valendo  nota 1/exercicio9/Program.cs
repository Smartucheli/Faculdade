using System;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, NovSalario, Reajuste, Percent;
            Console.WriteLine("Digite o salario");
            salario = float.Parse(Console.ReadLine());
            if( salario <= 400){
                Percent = 0.15;
                Reajuste = salario*Percent;
                NovSalario = salario+Reajuste;
                Console.WriteLine("Novo salario: {0:0.00}", NovSalario); 
                Console.WriteLine("Reajuste ganho: {0:0.00}", Reajuste); 
                Console.WriteLine("Em percentual: 15%");
            } else if (salario <= 800){
                Percent = 0.12;
                Reajuste = salario*Percent;
                NovSalario = salario+Reajuste;
                Console.WriteLine("Novo salario: {0:0.00}", NovSalario); 
                Console.WriteLine("Reajuste ganho: {0:0.00}", Reajuste); 
                Console.WriteLine("Em percentual: 12%");
            } else if (salario <= 1200){
                Percent = 0.1;
                Reajuste = salario*Percent;
                NovSalario = salario+Reajuste;
                Console.WriteLine("Novo salario: {0:0.00}", NovSalario); 
                Console.WriteLine("Reajuste ganho: {0:0.00}", Reajuste); 
                Console.WriteLine("Em percentual: 10%");
            } else if (salario <= 2000){
                Percent = 0.07;
                Reajuste = salario*Percent;
                NovSalario = salario+Reajuste;
                Console.WriteLine("Novo salario: {0:0.00}", NovSalario); 
                Console.WriteLine("Reajuste ganho: {0:0.00}", Reajuste); 
                Console.WriteLine("Em percentual: 7%");
            } else {
                Percent = 0.04;
                Reajuste = salario*Percent;
                NovSalario = salario+Reajuste;
                Console.WriteLine("Novo salario: {0:0.00}", NovSalario); 
                Console.WriteLine("Reajuste ganho: {0:0.00}", Reajuste); 
                Console.WriteLine("Em percentual: 4%");
            }

        }
    }
}
