//2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
//Álcool:
//. até 20 litros, desconto de 3% por litro Álcool
//. acima de 20 litros, desconto de 5% por litro

//Gasolina:
//. até 20 litros, desconto de 4% por litro Gasolina
//. acima de 20 litros, desconto de 6% por litro

//Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível codificado da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
//sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.


//métodos/funções
static float Alcool(float quantidade, float preco)
{
    if (quantidade <= 20)
    {
        return (quantidade * preco) * 0.97f;
    }

    else
    {
        return (quantidade * preco) * 0.95f;
    }
}
static float Gasolina(float quantidade, float preco)
{
    if (quantidade <= 20)
    {
        return (quantidade * preco) * 0.96f;
    }

    else
    {
        return (quantidade * preco) * 0.94f;
    }
}

//iniciar
Console.WriteLine($@"Bem vindo(a) ao nosso posto!");

//variáveis
float quantAlcool;
float quantGasolina;

const float precoAlcool = 4.90f;
const float precoGasolina = 5.30f;

float valorAbastecimento;
char tipo;

do
{
    //menu de opções 

    Console.WriteLine($@"Escolha o tipo de combustível:
A- Álcool
G- Gasolina");

    tipo = char.Parse(Console.ReadLine()!.ToUpper());

    switch (tipo)
    {
        case 'A':
            Console.WriteLine($"Informe a quantidade de Álcool que você deseja:");
            quantAlcool = float.Parse(Console.ReadLine()!);

            valorAbastecimento = Alcool(quantAlcool, precoAlcool);
            Console.WriteLine($"O valor do abastecimento é de: R${Math.Round(valorAbastecimento)}");
            break;

        case 'G':
            Console.WriteLine($"Informe a quantidade de Gasolina que você deseja:");
            quantGasolina = float.Parse(Console.ReadLine()!);

            valorAbastecimento = Gasolina(quantGasolina, precoGasolina);
            Console.WriteLine($"O valor do abastecimento é de: R${Math.Round(valorAbastecimento)}");
            break;

        default:
            Console.WriteLine($"Opção inválida! Apenas disponibilizamos Álcool e Gasolina!");

            break;
    }

} while (tipo != 'A' && tipo != 'G');

