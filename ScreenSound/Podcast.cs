class Podcast
{
     private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string host, string nome)
    {
        Nome = nome;
        Host = host;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
        
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"podcast - {Nome} apresentado por {Host}\n");
        foreach(Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Este podcast possui {TotalEpisodios} episódios.");
    }
}