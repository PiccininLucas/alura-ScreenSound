class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nomeDoAlbum)
    {
        NomeDoAlbum = nomeDoAlbum;
    }

    public string NomeDoAlbum { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum '{NomeDoAlbum}':\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.NomeDaMusica}");
        }
        Console.WriteLine($"Para ouvir esse álbum inteiro é necessário {DuracaoTotal} segundos");
    }
}