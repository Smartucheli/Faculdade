internal abstract class moto : Veiculo {
     protected Tamanho tamanho;

     protected Cilindrada cilindrada;

     protected moto(string placa, int documento, string dono): base(placa, documento, dono){
        Pneus = 2;
     }

     public virtual string Nao_tem_seguro(){
        return "Não tem seguro";
     }

     public override string ToString()
    {
        return $"{base.ToString()} Seguro: {Nao_tem_seguro()}\ntamanho: {tamanho}\nCilindrada: {cilindrada}";
    }
}