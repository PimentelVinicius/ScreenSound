namespace ScreenSound.Modelos;

public class BandaAvaliacao
{
    public BandaAvaliacao()
    {
    }

    public BandaAvaliacao(int nota)
    {
        if (nota < 0) nota = 0;
        if (nota > 10) nota = 10;
        BandaAvaliacaoNota = nota;
    }
    public int BandaAvaliacaoId { get; set; }
    public int BandaAvaliacaoNota { get; set; }
    public virtual Banda Banda { get; set; }



    public static BandaAvaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new BandaAvaliacao(nota);
    }
}
