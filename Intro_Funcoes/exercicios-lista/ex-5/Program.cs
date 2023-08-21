// Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Tabuada do {i}:");
    for (int num = 0; num <= 10; num++)
    {
        Console.WriteLine($"{i} x {num} = {i*num}");
    }
}
