namespace ScreenSound.Modelos;
public class Musica
{
    public Musica()
    {

    }
    public Musica(string Musicanome)
    {
        
        MusicaNome = Musicanome;
    }

    public string MusicaNome { get; set; }
    public int Id { get; set; }
    public int? AnoLancamento { get; set; }

    public virtual Artista? Artista { get; set; }
    //public Banda Artista { get; }
    //public int Duracao { get; set; }
    //public bool Disponivel { get; set; }
    //public string DescricaoResumida => $"A música {AlbumNome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"AlbumNome: {MusicaNome}");
        //Console.WriteLine($"Artista: {Artista.AlbumNome}");
        //Console.WriteLine($"Duração: {Duracao}");
        //if (Disponivel)
        //{
            //Console.WriteLine("Disponível no plano.");
        //} else
        //{
        //    Console.WriteLine("Adquira o plano Plus+");
        //}
    }
}