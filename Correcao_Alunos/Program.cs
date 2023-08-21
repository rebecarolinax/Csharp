using correcao_alunos;
Cadastrar aluno = new Cadastrar();

//perguntas do console:
Console.WriteLine($"Informe o nome do(a) aluno(a):");
aluno.Nome = Console.ReadLine();

Console.WriteLine($"Informe o curso do(a) aluno(a):");
aluno.Curso = Console.ReadLine();

Console.WriteLine($"Informe a idade do(a) aluno(a):");
aluno.Idade = Console.ReadLine();

Console.WriteLine($"Informe o RG do(a) aluno(a):");
aluno.Rg = Console.ReadLine();

Console.WriteLine($"Informe a média final do(a) aluno(a):");
aluno.MediaFinal = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a mensalidade do curso desejado:");
aluno.ValorMensalidade = float.Parse(Console.ReadLine());

//boleano (bolsista):
Console.WriteLine($"O(a) aluno(a) é bolsista? S/N:");
string resposta = Console.ReadLine().ToUpper();

if (resposta == "S")
{
    aluno.Bolsista = true;
}

else
{
    aluno.Bolsista = false;
}

//operador ternário: aluno.Bolsista = resposta == "S" ? true : false;

//menú de opções:
string opcao;
do
{
    Console.WriteLine($@"
---------------------------
Escolha uma das opções abaixo no menu:
(1) - Visualizar a média final
(2) - Valor da mensalidade
(0) - Sair
");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            aluno.VerMediaFinal();
            break;

        case "2":
            aluno.VerMensalidade();
            break;

        case "0":
            Console.WriteLine($"Programa finalizado, obrigada por utilizar nossos serviços!");
            break;

        default:
            Console.WriteLine($"Opção inválida, tente novamente!");
            break;
    }
} while (opcao != "0");

