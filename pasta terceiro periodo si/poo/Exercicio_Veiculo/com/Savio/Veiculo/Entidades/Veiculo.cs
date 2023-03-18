class Veiculo {

    private string placa;
    private int documento;
    private int pneus;
    private string dono;

    protected string Placa { get => placa; set => placa = value; }
    protected int Documento { get => documento; set => documento = value; }
    protected int Pneus { get => pneus; set => pneus = value; }
    protected string Dono { get => dono; set => dono = value; }

    public Veiculo() { }

    public Veiculo(string placa, int documento, string dono){
        this.placa = placa;
        this.documento = documento;
        this.dono = dono;
    }

    public override string ToString()
    {
        return $"\nPlaca: {Placa}\nDocumento: {documento}\nDono: {Dono}\nQuantidade de rodas: {Pneus}";
    }
}