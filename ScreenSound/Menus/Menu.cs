using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public virtual void Executar(DAL<Artista> ArtistaDAL)
    {
        Console.Clear();
    }

    public virtual void ExecutarMusica(DAL<Musica> musicaDAL)
    {
        Console.Clear();
    }
    public virtual void ExecutarBanda(DAL<Banda> bandaDAL)
    {
        Console.Clear();
    }

    public virtual void ExecutarAlbum(DAL<Album> albumDAL)
    {
        Console.Clear();
    }
}
