using OpenAI_API;
using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{

    public override void ExecutarBanda(DAL<Banda> BandaDAL)
    {
        base.ExecutarBanda(BandaDAL);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        



        //var client = new OpenAIAPI("verificar no bloco de Notas");

        //var chat = client.Chat.CreateConversation();

        //chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo. Adote um estilo informal.");

        //string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        banda.Resumo = $"Banda daora essa {nomeDaBanda}";

        BandaDAL.Adicionar(banda);

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine(banda.Resumo);

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();

    } 
    
}
