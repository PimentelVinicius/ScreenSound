using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarAlbum : Menu
{
    public override void ExecutarBanda(DAL<Banda> bandaDAL)
    {
        base.ExecutarBanda(bandaDAL);
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        var bandaSelect = bandaDAL.RecuperarPor(select => select.BandaNome.Equals(nomeDaBanda));
        if (bandaSelect is not null)
        {
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
    
            bandaSelect.AdicionarAlbum(new Album(tituloAlbum));

            bandaDAL.Atualizar(bandaSelect);
            Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
            Thread.Sleep(4000);
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

