using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            int []temperaturaF = new int [101];
            int i;
            Converte_temp(temperaturaF);
            Console.WriteLine("C \t F");
            for(i = 0; i <= 100; i++){
                Console.WriteLine(i + "\t" + temperaturaF[i]);
            }
        }

        static void Converte_temp(int []temp){
            int i = 0;
            for(i = 0; i <= 100; i++){
                temp[i] = (9*i)/5 + 32;
            }
        }
    }
}
