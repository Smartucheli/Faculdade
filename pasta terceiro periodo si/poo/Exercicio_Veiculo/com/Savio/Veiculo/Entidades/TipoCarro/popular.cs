internal class Popular : carro {
    protected string cor;
    protected string modelo;
    protected bool ar_cond;
    protected bool radio;
    protected cavalo cavalos;
    protected Tipo_combustivel tipo_comb;

    public Popular(string placa, int documento, string dono): base(placa, documento, dono){
        cor = "Branco";
        modelo = "uno";
        ar_cond = false;
        radio = false;
        cavalos = cavalo.pequeno;
        tipo_comb = Tipo_combustivel.alcool_gasolina;

    }
    public override string ToString()
    {
        return $"{base.ToString()}\nCor: {cor}\nModelo: {modelo}\nAr_condicionado: {ar_cond}\nradio: {radio}\nCavalos: {cavalos}\nTipo_combustivel {tipo_comb}";
    }

}