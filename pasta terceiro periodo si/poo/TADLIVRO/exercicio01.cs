using System;

class Exercicio01{

    //Função tipo bool, se for da era barroca retorna true se não false 
    static public bool livro_barroco(Livro livro){
        if(livro.ano >= 1681 && livro.ano <= 1768){
            return true;
        } else {
            return false;
        }
    }

    //Função tipo bool, se for da era modernista retorna true se não false 
    static public bool livro_modernismo(Livro livro){
        if(livro.ano >= 1930 && livro.ano <= 1945){
            return true;
        } else {
            return false;
        }
    }

    // função que verifica o livro passado no program usando os metodos anteriores
    static public void verifica_barroco_modernismo(Livro livro){
        if(livro_barroco(livro) == true){
            Console.WriteLine("O livro é da era barroca");
        } else if(livro_modernismo(livro) == true ){
            Console.WriteLine("O livro é da era modernista");
        } else if (livro_modernismo(livro) == false && livro_modernismo(livro) == false){
            Console.WriteLine("O livro não é da era barroca e modernista");
        }
    }

}