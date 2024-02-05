using projeto_celular;

Celular celular = new Celular();

Console.WriteLine($"Olá, nos descreva algumas características do seu celular. Começando pelo sua cor:");
celular.Cor = Console.ReadLine()!;

Console.WriteLine($"Agora nos informe seu modelo:");
celular.Modelo = Console.ReadLine()!;

Console.WriteLine($"E seu tamanho em polegadas:");
celular.Tamanho = Console.ReadLine()!;

Console.WriteLine(@$"Deseja ligar seu celular?
S - Sim
N - Não");
string ligarResposta = Console.ReadLine()!.ToUpper();

if (ligarResposta == "S")
{
    celular.ligarCelular();
    string escolha;

do
{
    Console.WriteLine(@$"Bem vindo ao nosso menu! Escolha o que deseja fazer com seu telefone:
    1- Ligar
    2- Enviar mensagem
    3- Fazer ligação
    4- Desligar
    0 - Sair");
    escolha = Console.ReadLine()!;

    if (escolha == "1")
    {
        celular.ligarCelular();
    }
    else if (escolha == "2")
    {
        Console.WriteLine($"Para quem deseja enviar mensagem?");
        string destinatario = Console.ReadLine()!;

        Console.WriteLine($"Digite a mensagem para {destinatario}");
        string mensagem = Console.ReadLine()!;

        celular.enviarMensagem(destinatario, mensagem);
    }
    else if (escolha == "3")
    {
        Console.WriteLine($"Para quem deseja ligar?");
        string destinatario = Console.ReadLine()!;

        celular.fazerLigacao(destinatario);
    }
    else if (escolha == "4")
    {
        celular.desligarCelular();
    }
    else
    {
        Console.WriteLine($"Não foi possível identificar. Tente novamente!");
    }
    
} while (escolha != "0");
}
else if (ligarResposta == "N")
{
    celular.desligarCelular();
}
else
{
    Console.WriteLine($"Tente novamente.");
    ligarResposta = Console.ReadLine()!.ToUpper();
}



