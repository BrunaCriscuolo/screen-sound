class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\n\nLista de episódios do podicast {Nome}: \n");
        foreach (var episodio in episodios.OrderBy(ep => ep.Ordem))
        {
            Console.WriteLine($"\n\nEpisódio: {episodio.Titulo}");
            Console.WriteLine($"Resumo: {episodio.Resumo}");
        }
        Console.WriteLine($"\nEsse podcast possui: {TotalEpisodios} episódios");
    }
}