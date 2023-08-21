//calculadora

//algoritmo

//1. Informar a operação

//2. Informar o primeiro numero

//3. Informar o segundo numero

//4. processar os dados

//5. exibir o resultado

//entrada

Console.WriteLine(@$"
   Programa de calculadora                               
                          
    Informe a operação                               
    (+) soma              
    (-) substração         
    (x) multiplicação     
    (/) divisao           

");

char operacao = char.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o primeiro numero");
double num1 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o segundo numero");
double num2 = double.Parse(Console.ReadLine()!);

double resultado = 0;

// processamento
// saida

switch (operacao)
{
    case '+':
        resultado = (num1 + num2);
        Console.WriteLine(resultado);
        break;

    case '-':
        resultado = (num1 - num2);
        Console.WriteLine(resultado);
        break;

    case 'x':
        resultado = (num1 * num2);
        Console.WriteLine(resultado);
        break;

    case '/':
        resultado = (num1 / num2);
        Console.WriteLine(resultado);
        break;

    default:
        Console.WriteLine($"Operação inválida");
        break;
}
