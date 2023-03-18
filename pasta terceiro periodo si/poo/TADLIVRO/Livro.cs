using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Livro {

        //propriedades
        public string titulo;
        public string autor;
        public string genero;
        public int ano;

        //Construtores
        public Livro(string titulo, string autor, string genero, int ano)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.genero = genero;
            this.ano = ano;
        }

        //encapsulamento
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Genero { get => genero; set => genero = value; }

        

    }
