using System;
using System.IO;


namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            string aluno;
            StreamWriter saida = new StreamWriter("c:\\Alunos.txt"); 
            Console.Write("Informe um aluno: ");
            aluno = Console.ReadLine();
            while(aluno != "fim"){
                saida.WriteLine(aluno);
                Console.Write("Informe um aluno: ");
                aluno = Console.ReadLine();
            }
            saida.Close();
        }
    }
}
