//Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

//Condicional Composta.

Console.WriteLine($"Digite o seu salário:");
float salarioRecebido = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o gasto do orçamento: ");
float orçamento = float.Parse(Console.ReadLine()!);

if (orçamento < salarioRecebido)
{
    Console.WriteLine($"Gastos dentro do orçamento.");
}

 else
{
    Console.WriteLine($"Orçamento estourado");
}