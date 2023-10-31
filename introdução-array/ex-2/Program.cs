string[] nomes = new string[5];
int[] idades = new int[5];

Console.WriteLine($"Digite o nome e idade de 5 pessoas:");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o nome da {i + 1}º pessoa");
    nomes[i] = Console.ReadLine()!;

    Console.WriteLine($"Digite a idade da {i + 1}º pessoa");
    idades[i] = int.Parse(Console.ReadLine()!);

}


for (int i = 0; i < 5; i++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{i+1}) Nome: {nomes[i]}");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Idade: {idades[i]} anos");
    Console.ResetColor();

    Console.WriteLine();
    
}





