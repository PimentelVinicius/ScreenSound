

using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarBandasRegistradas : Menu
{
    public override void ExecutarBanda(DAL<Banda> bandaDAL)
    {
        base.ExecutarBanda(bandaDAL);
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");
        Console.WriteLine($"Bandas: ");
        foreach (var banda in bandaDAL.Listar())
        {
            Console.WriteLine($"{banda.BandaNome}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
      
    }
}
