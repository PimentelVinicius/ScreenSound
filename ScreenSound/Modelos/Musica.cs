namespace ScreenSound.Modelos;
public class Musica
{
    public Musica(string nome)
    {
        
        Nome = nome;
    }

    public string Nome { get; set; }
    public int Id { get; set; }
    public int? AnoLancamento { get; set; }

    public virtual Artista? Artista { get; set; }
    //public Banda Artista { get; }
    //public int Duracao { get; set; }
    //public bool Disponivel { get; set; }
    //public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        //Console.WriteLine($"Artista: {Artista.Nome}");
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