using System;
using System.IO;

Console.WriteLine("Digite um texto no console e sabera se é igual ao texto do arquivo ");
string texto_console = Console.ReadLine();

StreamReader sr = new StreamReader("arq1.txt");
string texto_arquivo = sr.ReadLine();

if(texto_arquivo == texto_console){
    Console.WriteLine("Chave aceita! textos são iguais.");
} else {
    Console.WriteLine("Chave negada! textos não são iguais.");
}
