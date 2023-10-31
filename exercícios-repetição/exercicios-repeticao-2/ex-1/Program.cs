//Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

Console.WriteLine($"Digite uma nota entre zero a dez:");
int notas = int.Parse(Console.ReadLine()!);

while (notas < 0 || notas > 10)
{
    Console.WriteLine($"Digite um número válido:");
    notas = int.Parse(Console.ReadLine()!);
   
}
