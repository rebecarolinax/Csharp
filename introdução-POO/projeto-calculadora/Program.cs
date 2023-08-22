using projeto_calculadora;
//exibindo ao usuário:

string operacao;
//chamando a calculadora:
Calc calculando = new Calc();
do
{
    Console.WriteLine($@"Muito obrigado(a) por utilizar os nossos serviços!
Por favor, escolha sua operação:
1- Soma
2- Subtração
3- Divisão
4- Multiplicação
0- Fim do programa
");

    //resposta do usuário:
    operacao = Console.ReadLine()!;

    //perguntando os valores:
    Console.WriteLine($"Agora informe seu primeiro número:");
    calculando.n1 = float.Parse(Console.ReadLine()!);

    Console.WriteLine($"Agora informe seu segundo número:");
    calculando.n2 = float.Parse(Console.ReadLine()!);

    switch (operacao)
    {
        case "1":
            Console.WriteLine($"O resultado da sua Soma é {calculando.Soma()}");
            break;

        case "2":
            Console.WriteLine($"O resultado da sua Subtração é {calculando.Sub()}");
            calculando.Sub();
            break;

        case "3":
            Console.WriteLine($"O resultado da sua Divisão é {calculando.Divisao()}");
            calculando.Divisao();
            break;

        case "4":
            Console.WriteLine($"O resultado da sua Multiplicação é {calculando.Multipli()}");
            calculando.Multipli();
            break;

        case "0":
            Console.WriteLine($"Fim do programa, obrigado(a)!");
            break;

        default:
            Console.WriteLine($"Opção inválida, tente novamente!");
            break;
    }
} while (operacao != "0");

