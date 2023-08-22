//Faça um programa que receba um número inteiro e mostre a sua tabuada.

Console.WriteLine($"Digite um número inteiro e receba a sua tabuada:");
int numero = int.Parse(Console.ReadLine()!);

for (int vezes = 1; vezes <= 10; vezes++)
{
    int resultado = numero * vezes;
    Console.WriteLine($"{numero} * {vezes} = {resultado}");
}

