
using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void ExecutarAlbum(DAL<Album> albumDAL)
    {
        base.ExecutarAlbum(albumDAL);
       
        ExibirTituloDaOpcao("Avaliar Album");
        Console.Write("Digite o nome da album que deseja avaliar: ");
        string nomeDaAlbum = Console.ReadLine()!;
        var albumSelect = albumDAL.RecuperarPor(select => select.AlbumNome.Equals(nomeDaAlbum));

        if (albumSelect is not null)
        {
            //Banda banda = albumSelect;
            //Console.Write("Agora digite o título do álbum: ");
            //string tituloAlbum = Console.ReadLine()!;


            Album album = albumSelect;
            Console.Write($"Qual a nota que a álbum {nomeDaAlbum} merece: ");
            AlbumAvaliacao nota = AlbumAvaliacao.Parse(Console.ReadLine()!);
            albumSelect.AdicionarNota(nota);
            albumDAL.Atualizar(album);

            //if (banda.Albuns.Any(a => a.AlbumNome.Equals(tituloAlbum)))
            //{
            //    Album album = banda.Albuns.First(a => a.AlbumNome.Equals(tituloAlbum));

            //    Console.Write($"Qual a nota que a álbum {tituloAlbum} merece: ");
            //    BandaAvaliacao nota = BandaAvaliacao.Parse(Console.ReadLine()!);
            //    album.AdicionarNota(nota);
            //    bandaDAL.Atualizar(banda);


            //    Console.WriteLine($"\nA nota {nota.BandaAvaliacaoNota} foi registrada com sucesso para a album {tituloAlbum}");
            //    Thread.Sleep(5000);
            //    Console.Clear();
            //}
            //else
            //{
            //    Console.WriteLine($"\nA álbum {tituloAlbum} não foi encontrada!");
            //    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            //    Console.ReadKey();
            //    Console.Clear();
            //}


         

        }
        else
        {
            Console.WriteLine($"\nO album {nomeDaAlbum} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
