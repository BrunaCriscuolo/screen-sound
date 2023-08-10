Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life", true)
{
    Duracao = 300,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody", true)
{
    Duracao = 150,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);


queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();
albumDoQueen.ExibirMusicas();
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

Podcast psicologiaNaPratica = new Podcast("Psicologia na prática", "Alana Anijar");

Episodio episodio1 = new Episodio("Transtorno de ansiedade", 1, 30);
Episodio episodio2 = new Episodio("TDHA", 2, 30);

episodio1.AdicionarConvidados("Joana da SIlva");
episodio1.AdicionarConvidados("Joaquim da Silva");

episodio2.AdicionarConvidados("Paulo Mendes");
episodio2.AdicionarConvidados("Pedro Camargo");

psicologiaNaPratica.AdicionarEpisodio(episodio1);
psicologiaNaPratica.AdicionarEpisodio(episodio2);
psicologiaNaPratica.ExibirDetalhes();