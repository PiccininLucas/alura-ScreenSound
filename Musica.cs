class Musica
{
    public Musica(Banda artista, string nomeDaMusica)
    {
        Artista = artista;
        NomeDaMusica = nomeDaMusica;
    }

    public string NomeDaMusica { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida => $"A música {NomeDaMusica} pertence ao artista {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {NomeDaMusica}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o premium.");
        }
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"\nNome: {NomeDaMusica}");
        Console.WriteLine($"Artista: {Artista}");
    }
}