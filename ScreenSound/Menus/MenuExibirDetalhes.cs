using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{

    public override void ExecutarBanda(DAL<Banda> bandaDAL)
    {
        base.ExecutarBanda(bandaDAL);
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        var bandaSelect = bandaDAL.RecuperarPor(select => select.BandaNome.Equals(nomeDaBanda));

        if (bandaSelect is not null)
        {
            Banda banda = bandaSelect;
            Console.WriteLine(banda.Resumo);
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            Console.WriteLine("\nDiscografia:");
            foreach(Album album in banda.Albuns)
            {
                Console.WriteLine($"{album.AlbumNome} =-> {album.Media}");
            }
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
           

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
          
        }
    }
}