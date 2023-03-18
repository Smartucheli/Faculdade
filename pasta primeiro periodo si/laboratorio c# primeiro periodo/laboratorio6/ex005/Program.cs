using System;

namespace ex005
{
    class Program
    {
        static void Main(string[] args)
        {
          
          double menorG = -1, maiorG = 10000, maiorA = 10000, menorA = -1, maiorD = 10000, menorD = -1, gas = 0, alc, die;
          while(gas != 0){
              Console.Write("Digite o preço da gasolina: ");
              gas = double.Parse(Console.ReadLine());
              Console.Write("Digite o preço do alcool: ");
              alc = double.Parse(Console.ReadLine());
              Console.Write("Digite o valor do diesel: ");
              die = double.Parse(Console.ReadLine());
              if(gas > maiorG) maiorG = gas;
              if(gas < menorG) menorG = gas;
              if(alc > maiorA) maiorA = alc;
              if(alc < menorA) menorA = alc;
              if(die > maiorD) maiorD = die;
              if(die < menorD) menorD = die;
          }
          Console.WriteLine("o maior e menor valor de gasolina são: {0} e {1}", maiorG, menorG);
          Console.WriteLine("o maior e menor valor de alcool são: {0} e {1}", maiorA, maiorA);
          Console.WriteLine("o maior e menor valor de diesel são: {0} e {1}" , maiorD, maiorD);
        }
          
        }
   }



