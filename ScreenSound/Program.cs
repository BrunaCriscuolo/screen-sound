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


