class Conta {
    private string nome;
    private double cpf;

    private int importancia;

    public string Nome { get => nome; set => nome = value; }
    public double Cpf { get => cpf; set => cpf = value; }
    public int Importancia { get => importancia; set => importancia = value; }

    public Conta(string nome, double cpf, int importancia){
        this.nome = nome;
        this.cpf = cpf;
        this.importancia = importancia;
    }

    public void Testa_importancia(int importancia){
        if(importancia == 1){
            Console.WriteLine("Sua conta não é premium");
            
        } else {
            Console.WriteLine("Sua conta é premium");
        }
    }

    
}