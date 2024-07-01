namespace ScreenSound.Modelos;
public class Album
{
    private List<Musica> musicas = new List<Musica>();
    public virtual List<AlbumAvaliacao> Notas { get; set; } = new List<AlbumAvaliacao>();

    public Album() { }
    public Album(string AlbumNome)
    {
        this.AlbumNome = AlbumNome;
    }

    public int AlbumId { get; set; }
    public string AlbumNome { get; set;}
    public int BandaId { get; set; }
    public virtual Banda Banda { get; set; }
    //public int DuracaoTotal => Musicas.Sum(m => m.Duracao);
    public virtual List<Musica> Musicas => musicas;

    public double Media {
        get
        {
            if (Notas.Count == 0) return 0;
            else return Notas.Average(avaliacaos => avaliacaos.AlbumAvaliacaoNota);
        }
       
    }
     
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void AdicionarNota(AlbumAvaliacao nota)
    {
        Notas.Add(nota);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {AlbumNome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.MusicaNome}");
        }
        //Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }

    public static string ContadorDeObjetos(List<Album> albuns)
    {
        return $"A banda tem {albuns.Count} albuns.";
    }

   
}