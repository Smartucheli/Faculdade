using System;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temperatura = new int[10];
            int i, pmaior = 0, pmenor = 0;
            float media;
            LeVetor(temperatura);
            media = mediaVetor(temperatura);
            Console.Write("A temperatura media nesses 10 dias foi: {0}", media); 
            MAIORMENOR(temperatura, ref pmaior, ref pmenor);
            Console.Write("\nA maior temperatura foi: {0}", temperatura[pmaior]);
            Console.Write("\nA menor temperatura foi: {0}", temperatura[pmenor]);
            for(i = 0; i < 10; i++){
                if(temperatura[i] < media)
                    Console.Write("\nnos dias {0} a temperatura foi menor que media. ", i + 1);
            }            
        }

        static void LeVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite uma temperatura : [{0}]", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }


        static float mediaVetor(int []temperatura){
            float soma = 0;
            int i =0;
            for(i = 0; i < temperatura.Length; i++){
                soma += temperatura[i];
            }
            return soma/temperatura.Length;
        }

        static void MAIORMENOR(int []temperatura, ref int pmaior, ref int pmenor){
            int i;
            pmenor = 0;
            pmaior = 0;
            for(i = 0; i < temperatura.Length; i++){
                if( temperatura[i] > temperatura[pmaior])
                    pmaior = i;
                if( temperatura[i] < temperatura[pmenor])
                    pmenor = i;    
            }
        }

    }
}
