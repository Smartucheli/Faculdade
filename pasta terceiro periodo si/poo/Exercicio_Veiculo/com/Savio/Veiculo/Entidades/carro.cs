internal abstract class carro : Veiculo {

    private bool farol;
    private int portas;

   
    protected int Portas { get => portas; set => portas = value; }

    protected carro(string placa, int documento, string dono) : base(placa, documento, dono){
        Pneus = 4;
        portas = 4;
        farol = true;
    }

    public virtual string Tem_Seguro(){
        return "Tem seguro";
    }

    public override string ToString()
    {
        return $"{base.ToString()}seguro: {Tem_Seguro()}\nPortas: {portas} \nFarol: {farol}";
    }
}