using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
               int horas;
            Console.WriteLine("Digite um horario: ");
            horas = int.Parse(Console.ReadLine());
            if(horas==3){
                Console.WriteLine("matinas");
            } else if (horas==5 ){
                 Console.WriteLine("laudes");
            } else if (horas==7){
                 Console.WriteLine("Prima");
            } else if (horas==9){
                 Console.WriteLine("Tercia");
            } else if(horas==12){
                 Console.WriteLine("Sexta");
            } else if (horas==15){
                Console.WriteLine("Noa");
            } else if (horas==18){
                Console.WriteLine("Vésperas");
            } else if(horas==21){
                Console.WriteLine("completas");
                } else {
                Console.WriteLine("Não é canonico");
            }
        }
    }
}
