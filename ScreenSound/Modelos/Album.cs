﻿namespace ScreenSound.Modelos;
internal class Album : IAvaliavel
{
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    //public int DuracaoTotal => Musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;

    public double Media {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(avaliacaos => avaliacaos.Nota);
        }
       
    }
     
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        //Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }

    public static string ContadorDeObjetos(List<Album> albuns)
    {
        return $"A banda tem {albuns.Count} albuns.";
    }

   
}