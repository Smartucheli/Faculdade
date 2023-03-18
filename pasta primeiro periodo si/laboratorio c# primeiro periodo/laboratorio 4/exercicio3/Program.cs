using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia,mes, ano;
            Console.WriteLine("Escreva um dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva um mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva um ano: ");
            ano = int.Parse(Console.ReadLine());
            int jan=0, fev=28, março=31, abril=30, maio=31, jun=30, jul=31, agost=31, set=30, outu=31, nov=30, dez=31;
            if(mes==01){
                dia+=jan;
                Console.WriteLine("O dia em juliano é: " + dia + "/" + ano);
            } else if (mes==02){
                dia +=fev;
                Console.WriteLine("O dia em juliano é: " + dia + "/" + ano);
            } else if (mes ==03){
                dia = fev+março;
                Console.WriteLine("O dia em juliano é: " + dia + "/" + ano);
            } else if (mes ==04){
                dia = dia+fev+março+abril;
                Console.WriteLine("O dia em juliano é: " + dia + "/" + ano);
            } else if (mes ==05){
                dia = dia+fev+março+abril+maio;
                Console.WriteLine("O dia em juliano é: " + dia + "/" + ano);
            } else if (mes==06){
                dia = dia+fev+março+abril+maio+jun;
                Console.WriteLine("O dia em juliano é: " + dia + "/" + ano);
            } else if (mes==07){
                dia = dia+fev+março+abril+jun+jul;
                Console.WriteLine("O dia em juliano é: " + dia + "/" + ano);
            } else if(mes==08){
                dia = dia+fev+março+abril+jun+jul+agost;
                Console.WriteLine("O dia em juliano é: " + dia + "/" + ano);
            } else if(mes==09){
                dia = dia+fev+março+abril+maio+jun+jul+agost+set;
                Console.WriteLine("O dia em juliano é: " + dia + "/" + ano);
            } else if(mes ==10){
                dia= dia+fev+março+abril+maio+jun+jul+agost+set+outu;
                Console.WriteLine("O dia em juliano é: " + dia + "/" + ano);
            } else if(mes==11){
                dia= dia+fev+março+abril+maio+jun+jul+agost+set+outu+nov;
                Console.WriteLine("O dia em juliano é: " + dia + "/" + ano);
            } else{
                dia = dia+fev+março+abril+maio+jun+jul+agost+set+outu+nov+dez;
                Console.WriteLine("O dia em juliano é: " + dia + "/" + ano);
            }
        }
    }
}
