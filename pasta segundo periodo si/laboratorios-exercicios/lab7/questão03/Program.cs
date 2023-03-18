using System;
using System.IO;


static string inverte(string i){
    string aux = "";
    for(int j = i.Length-1; j>=0; j--){
        aux = aux + i[j];
    }
    return aux;
}

StreamWriter sw = new StreamWriter("Saida.txt");
StreamReader sr = new StreamReader("Entrada.txt");
string texto_arquivo = sr.ReadLine();
string new_texto = inverte(texto_arquivo);
sw.WriteLine(new_texto);
sw.Close();




