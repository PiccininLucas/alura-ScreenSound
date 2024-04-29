//Banda queen = new Banda("Queen");

//Album albumDoQueen =  new Album("A night at the opera");

//Musica musica1 = new Musica(queen, "Love of my Life")
//{
//    Duracao = 213,
//    Disponivel = true,
//};


//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Duracao = 354,
//    Disponivel = false,
//};


//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//queen.AdicionarAlbum(albumDoQueen);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//queen.ExibirDiscografia();

Episodio ep1 = new(1, "Tecnicas de Facilitacao", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(2, "Tecnicas de Aprendizado", 67);
ep2.AdicionarConvidados("Maria");
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Douglas");
Console.WriteLine(ep2.Resumo);

Podcast podcast = new("Podcast Tecnicas", "Maria");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();