class Episodio
{
    private List<string> convidados = new List<string>();

    public Episodio (string titulo, int ordem, int duracao) 
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao; 
    }

    public int Duracao {  get; }
    public int Ordem {  get; }
    public string Resumo =>
       $"{Ordem}º - O episódio {Titulo} possui a duração de {Duracao}min e convidados: {string.Join(", ", convidados)}";

    public string Titulo {  get; }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}