class Gerente {

    private string nome;
    private int n_id;

    public string Nome { get => nome; set => nome = value; }
    public int N_id { get => n_id; set => n_id = value; }

    public Gerente(string nome, int n_id){
        this.nome = nome;
        this.n_id = n_id;
    }


}