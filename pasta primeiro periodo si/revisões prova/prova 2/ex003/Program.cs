using System;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        
        static double Conta(int x){
            int  j;
            double i = 0, c = 0;
            for(i = 1, j = 1; i <= 99; i += 2, j++){
                c += i/j;
                return c;
            }
        }
    }
}
