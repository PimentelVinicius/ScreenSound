namespace ScreenSound.Modelos;
public class Banda : IAvaliavel
{
    public virtual ICollection<Album> Albuns { get; set; } = new List<Album>();
    public virtual List<BandaAvaliacao> notas { get; set; } = new List<BandaAvaliacao>();
    //public virtual List<Artista> Artistas { get; set; } = new List<Artista>();
    public Banda() { }
    public Banda(string nome)
    {
        BandaNome = nome;
    }

    public Banda(int bandaId, string bandaNome)
    {
        BandaId = bandaId;
        BandaNome = bandaNome;
    }

    public int BandaId { get; set; }
    public string? BandaNome { get; set; }

    //public virtual ICollection<Album> Albuns { get; set; } new List<Album>();
    public double Media 
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.BandaAvaliacaoNota);
        }
    }
    public string? Resumo { get; set; }
    //public virtual IEnumerable<Album> Albuns => albuns;

    public void AdicionarAlbum(Album album) 
    {
        Albuns.Add(album);
    }

    public void AdicionarNota(BandaAvaliacao nota)
    {
        notas.Add(nota);

    }

    //public void AdicionarArtista(Artista artista)
    //{
    //    Artistas.Add(artista);

    //}

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {BandaNome}");
        foreach (Album album in Albuns)
        {
            //Console.WriteLine($"Álbum: {album.AlbumNome} ({album.DuracaoTotal})");
        }
    }
}