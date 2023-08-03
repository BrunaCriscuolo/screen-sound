class Musica
{
    public Musica(Banda banda, string nome, bool disponivel) {
        Banda = banda;
        Nome = nome;
        Disponivel = disponivel;
    }

    public string Nome { get; }
    public Banda Banda { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; }
    public string DescricaoResumida => 
        $"A música {Nome} pertence à banda {Banda}";

    public Genero Genero { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Banda: {Banda.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}