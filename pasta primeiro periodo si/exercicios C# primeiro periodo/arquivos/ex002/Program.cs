using System;
using System.IO;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            string aluno;
            Console.Write("Aluno para pesquisa: ");
            aluno = Console.ReadLine();
            if(pesquisa(aluno, "c:\\alunos.txt")){
                Console.WriteLine("Aluno encontrado!");
            } else {
                Console.WriteLine("Aluno não encontrado");
            }
            
        }

        static bool pesquisa (String Alunopsq, string Arq){
            StreamReader entrada = new StreamReader(Arq);
            string alunoArq = Console.ReadLine();
            while(alunoArq != null){
                if(alunoArq == Alunopsq){
                    entrada.Close();
                    return true;
                } 
            }
            alunoArq = entrada.ReadLine();
            entrada.Close();
            return false;
        }
    }
}
