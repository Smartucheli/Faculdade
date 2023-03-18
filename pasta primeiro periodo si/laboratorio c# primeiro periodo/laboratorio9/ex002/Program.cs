using System;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
        int []pos = new int [7];
        int []neg = new int [7];
        int pcount = 0, ncount = 0;
        for(int i = 0; i < 7; i++){
                int valor;
                Console.WriteLine("Entre com o {0} valor", i+1);
                valor = int.Parse(Console.ReadLine());
                if( valor < 0){
                    neg[ncount++] = valor;
                } else {
                    pos[pcount++] = valor;
                }
            }    
            Console.WriteLine("Os numeros negativos são: " + ncount);
            Console.WriteLine("Os numeros positivos são: " + pcount);
            
        }
    
        
    }
}
