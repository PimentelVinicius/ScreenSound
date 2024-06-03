using ScreenSound.Banco;
using ScreenSound.Menus;
using ScreenSound.Modelos;

var context = new ScreenSoundContext();
var artistaDAL = new DAL<Artista>(context);
var musicaDAL = new DAL<Musica>(context);

Banda Legiao = new Banda("Legiao!");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(Legiao.Nome, Legiao);

//try
//{
//    Musica musica1 = new("Come as you are");


//    musicaDAL.Adicionar(musica1);

//    foreach (var item in musicaDAL.Listar())
//    {
//        Console.WriteLine(item.Nome);
//    }
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex);
//}

//return;

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarArtista());
opcoes.Add(2, new MenuRegistrarMusica());
opcoes.Add(3, new MenuMostrarArtistas());
opcoes.Add(4, new MenuMostrarMusicas());
opcoes.Add(5, new MenuExibirMusicaPorAno());
opcoes.Add(6, new MenuRegistrarBanda());

opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 3.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um artista");
    Console.WriteLine("Digite 2 para registrar a música de um artista");
    Console.WriteLine("Digite 3 para mostrar todos os artistas");
    Console.WriteLine("Digite 4 para exibir todas as músicas de um artista");
    Console.WriteLine("Digite 5 para exibir todas as músicas de um determinado ano");

    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(artistaDAL);
        menuASerExibido.ExecutarMusica(musicaDAL);
        menuASerExibido.ExecutarBanda(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

ExibirOpcoesDoMenu();








//Dictionary<int, Menu> opcoes = new();
//opcoes.Add(1, new MenuRegistrarBanda());
//opcoes.Add(2, new MenuRegistrarAlbum());
//opcoes.Add(3, new MenuMostrarBandasRegistradas());
//opcoes.Add(4, new MenuAvailiarBanda());
//opcoes.Add(5, new MenuAvaliarAlbum());
//opcoes.Add(6, new MenuExibirDetalhes());

//opcoes.Add(-1, new MenuSair());
//void ExibirLogo()
//{
//    Console.WriteLine(@"

//░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
//██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
//╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
//░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
//██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
//╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
//");
//    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
//}

//void ExibirOpcoesDoMenu()
//{
//    ExibirLogo();
//    Console.WriteLine("\nDigite 1 para registrar uma banda");
//    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
//    Console.WriteLine("Digite 3 para mostrar todas as bandas");
//    Console.WriteLine("Digite 4 para avaliar uma banda");
//    Console.WriteLine("Digite 5 para avaliar uma álbum");
//    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
//    Console.WriteLine("Digite -1 para sair");

//    Console.Write("\nDigite a sua opção: ");
//    string opcaoEscolhida = Console.ReadLine()!;
//    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

//    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
//    {
//        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
//        menuASerExibido.Executar(artistaDAL);
//        if(opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
//    }
//    else
//    {
//        Console.WriteLine("Opção inválida");
//    }

//}

//    ExibirLogo();
//    ExibirOpcoesDoMenu();






