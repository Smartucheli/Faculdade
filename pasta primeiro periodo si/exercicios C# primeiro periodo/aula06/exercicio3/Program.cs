using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;
            Console.WriteLine("Digite uma data: ");
            dia = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            ano = int.Parse(Console.ReadLine());
            if (mes == 01)
                Console.WriteLine(dia + " De Janeiro " + ano);
            if (mes == 02)
                Console.WriteLine(dia + " De Fevereiro " + ano); 
            if (mes == 03)
                Console.WriteLine(dia + " De Março " + ano); 
            if (mes == 04)
                Console.WriteLine(dia + " De Abril " + ano); 
            if (mes == 05)
                Console.WriteLine(dia + " De Maio " + ano); 
            if (mes == 06)
                Console.WriteLine(dia + " De Junho " + ano); 
            if (mes == 07)
                Console.WriteLine(dia + " De Julho " + ano); 
            if (mes == 08)
                Console.WriteLine(dia + " De Agosto " + ano); 
            if (mes == 09)
                Console.WriteLine(dia + " De Setembro " + ano); 
            if (mes == 10)
                Console.WriteLine(dia + " De Outubro " + ano); 
            if (mes == 11)
                Console.WriteLine(dia + " De Novembro " + ano); 
            if (mes == 12)
                Console.WriteLine(dia + " De Dezembro " + ano);
        }
    }
}
