class Episodio
{
    private List<Convidado> convidados = new List<Convidado>();

    public Episodio (string titulo, int ordem, int duracao) 
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao; 
    }

    public int Duracao {  get; }
    public int Ordem {  get; }
    public string Resumo =>
       $"{Ordem}º - O episódio {Titulo} possui a duração de {Duracao}min";

    public string Titulo {  get; }

    public void AdicionarConvidados(Convidado convidado)
    {
        convidados.Add(convidado);
    }

    public void MostrarConvidados()
    {
        Console.WriteLine($"\nLista de convidados:");
        foreach (var convidado in convidados)
        {
            Console.WriteLine($"Convidado: {convidado.Nome}");
        }
    }
}