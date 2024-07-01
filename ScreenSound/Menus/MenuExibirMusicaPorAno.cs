using ScreenSound.Banco;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuExibirMusicaPorAno : Menu
    {
        public override void Executar(DAL<Artista> artistaDAL)
        {
            base.Executar(artistaDAL);
            ExibirTituloDaOpcao("Exibir musica por ano.");
            Console.Write("Digite o ano: ");
            string anoDaMusica = Console.ReadLine()!;
            var musicaDal = new DAL<Musica>(new ScreenSoundContext());
            var musicaRecuperada = musicaDal.RecuperarColecaoPor(a => a.AnoLancamento == Convert.ToInt32(anoDaMusica));
            if (musicaRecuperada is not null)
            {

                Console.WriteLine("\nMusicas:");
                foreach(var itemMusica in musicaRecuperada)
                {
                    Console.WriteLine(itemMusica.MusicaNome);
                }
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO artista {anoDaMusica} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
