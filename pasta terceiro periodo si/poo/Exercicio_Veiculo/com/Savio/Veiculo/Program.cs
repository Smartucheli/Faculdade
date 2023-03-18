int op; 
int documento = 0;
string placa = "";
string dono = "";

Console.WriteLine("qual veiculo deseja criar: [1] - moto/ [2] - carro ");
op = int.Parse(Console.ReadLine());

switch(op)
{
    case 1:
        Console.WriteLine("Qual tipo de moto deseja criar -> [1] - scooter/ [2] - harley - [3] - ninja");
        op = int.Parse(Console.ReadLine());
        if(op == 1){
            Console.WriteLine("scooter");
            Dados_veiculo(ref placa, ref documento, ref dono);
            scooter Scooter  = new scooter(placa, documento, dono);
            Console.WriteLine(Scooter);
            break;
        } else if (op == 2){
            Console.WriteLine("harley");
            Dados_veiculo(ref placa, ref documento, ref dono);
            harley Harley = new harley(placa, documento, dono);
            Console.WriteLine(Harley);
            break;
        } else{
            Console.WriteLine("Ninja");
            Dados_veiculo(ref placa, ref documento, ref dono);
            ninja Ninja = new ninja(placa, documento, dono);
            Console.WriteLine(Ninja);
            break;
        }
        break;
    case 2:
        Console.WriteLine("Qual tipo de carro deseja criar -> [1] - caminhonete/ [2] - esportivo/ [3] - popular");
        op = int.Parse(Console.ReadLine());
        if(op == 1){
            Console.WriteLine("Caminhonete");
            Dados_veiculo(ref placa, ref documento, ref dono);
            Caminhonete caminhonete = new Caminhonete(placa, documento, dono);
            Console.WriteLine(caminhonete);
            break;
        }else if(op == 2){
            Console.WriteLine("Esportivo");
            Dados_veiculo(ref placa, ref documento, ref dono);
            Esportivo esportivo = new Esportivo(placa, documento, dono);
            Console.WriteLine(esportivo);
            break;
        } else {
            Console.WriteLine("Popular");
            Dados_veiculo(ref placa, ref documento, ref dono);
            Popular popular = new Popular(placa, documento, dono);
            Console.WriteLine(popular);
            break;
        }
        break;
       
}


static void Dados_veiculo( ref string placa,  ref int documento, ref string dono){
    Console.WriteLine("Digite a placa do veiculo");
    placa = Console.ReadLine();
    Console.WriteLine("Digite o documento do veiculo");
    documento = int.Parse(Console.ReadLine());
    Console.WriteLine("Quem é o dono do veiculo");
    dono = Console.ReadLine();
}