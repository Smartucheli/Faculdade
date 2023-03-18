using System;

namespace ex005
{
    class Program
    {
        static void Main(string[] args)
        {
             double cm, P = 0;
             Console.WriteLine("CM  \t  Polegadas");
             for(cm = 1;  cm <= 100 ; cm += 2){
                 P = cm * 0.3937;
                 Console.WriteLine("{0} \t {1} ",cm, P);
             }
        }
    }
  } 
