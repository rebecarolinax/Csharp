using projeto_aluno;

//declarando perguntas tipo string:
static string PerguntaString(string pergunta)
{
    Console.WriteLine(pergunta);
    return Console.ReadLine()!;
}

//declarando perguntas tipo char:
static char PerguntaChar(string pergunta)
{
    Console.WriteLine(pergunta);
    return char.Parse(Console.ReadLine()!);
}

//declarando perguntas tipo int:
static int PerguntaInt(string pergunta)
{
    Console.WriteLine(pergunta);
    return int.Parse(Console.ReadLine()!);
}

//declarar perguntas tipo float:
static float PerguntaFloat(string pergunta)
{
    Console.WriteLine(pergunta);
    return float.Parse(Console.ReadLine()!);
}


//exibir mensagem quando dada a função (sem retorno):
static void ExibirTexto(string texto)
{
    Console.WriteLine(texto);
}

static void ExibeMensagem(string texto)
{
    Console.Write(texto);
}
//exibir mensagem quando dada a função (sem retorno)


//declarando função de cadastro:
string opcao;

CadastrarAluno aluno = new CadastrarAluno();

aluno.Nome = PerguntaString("Digite o nome do Aluno(a):");

aluno.Idade = PerguntaString($"Digite a idade do(a) {aluno.Nome}:");

aluno.Rg = PerguntaString($"Digite o RG do(a) {aluno.Nome}:");


//declarando boleana (bolsista)
string boleano = PerguntaString("Aluno(a) é bolsista (sim) ou (não):");

if (boleano == "sim")
{
    aluno.Bolsista = true;
}

else
{
    aluno.Bolsista = false;
}

aluno.MediaFinal = PerguntaFloat($"Digite a média final do {aluno.Nome}");

aluno.ValorMensalidade = PerguntaFloat($"Digite o valor da mensalidade a ser paga pelo(a) {aluno.Nome}");

do
{
    opcao = PerguntaString(@"
    ---------------------------
Escolha uma das opções abaixo no menu:
(1) - Visualizar a média
(2) - Valor da mensalidade
(0) - Sair
");

    switch (opcao)
    {
        case "1":
            aluno.VerMediaFinal();
            break;

        case "2":
            aluno.VerMensalidade();
            break;

        case "0":
            Console.WriteLine($"Obrigado(a) por utilizar nosso sistema!");

            break;
        default:
            Console.WriteLine($"Opção inválida. Tente novamente!");
            break;
    }
} while (opcao != "0");

