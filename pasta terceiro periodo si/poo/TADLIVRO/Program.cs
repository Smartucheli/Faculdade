using System;


namespace Program {

    class Program{

        static void Main(string[] args){
            
            // -------- exercicio 01 ---------
            Livro livro1 = new Livro("teste-A", "Teste-A", "Teste-G", 1700);

            Exercicio01.verifica_barroco_modernismo(livro1);

            // -------- exercicio 02 ---------

            int []vet = new int[5] {20, 60, 80, 10, 5};
            Exercicio02.imprimir(vet);
            Exercicio02.ordena_livro(vet);
            Exercicio02.imprimir(vet);

        }

    }

}