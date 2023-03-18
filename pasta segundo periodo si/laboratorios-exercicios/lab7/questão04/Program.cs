//gera cpf 
static string gera_cpf(){
    int soma = 0, resto = 0;
    int []peso1 = new int [9]{10, 9, 8, 7, 6, 5, 4, 3, 2 };
    int []peso2 = new int [10]{11, 10, 9, 8, 7, 6, 5, 4, 3, 2};
    Random rnd = new Random();
    string semente = rnd.Next(100000000, 999999999).ToString();
    for(int i = 0; i <= 8; i++){
        soma += int.Parse(semente[i].ToString()) * peso1[i];
    }
    resto = soma % 11;
    if(resto < 2){
        resto = 0;
    } else {
        resto = 11 - resto;
    }
    semente = semente + resto;
    soma = 0;
    for(int i = 0; i < 10; i++){
        soma += int.Parse(semente[i].ToString()) * peso2[i];
    }
    resto = soma % 11;
    if(resto < 2){
        resto = 0;
    } else {
        resto = 11- resto;
    }
    semente = semente + resto;
    return semente;
}


//gera 50000 cpfs 

int i = 0;
while(i < 50000){
    Console.WriteLine(gera_cpf());
    i++;
}