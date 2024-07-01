using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvailiarBanda : Menu
{
    
    public override void ExecutarBanda(DAL<Banda> bandaDAL)
    {
        base.ExecutarBanda(bandaDAL);
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        var bandaSelect = bandaDAL.RecuperarPor(select => select.BandaNome.Equals(nomeDaBanda));
        if (bandaSelect is not null)
        {
            Banda banda = bandaSelect;
            Console.Write($"Qual a nota que a banda {bandaSelect.BandaNome} merece: ");
            BandaAvaliacao nota = BandaAvaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            bandaDAL.Atualizar(banda);
            
            Console.WriteLine($"\nA nota {nota.BandaAvaliacaoNota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(5000);
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
