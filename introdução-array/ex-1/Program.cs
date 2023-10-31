int[] num = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    num[i] = int.Parse(Console.ReadLine()!);
}

foreach (var numero in num)
{
    Console.WriteLine($"O dobro do número {numero} é {numero*2}!");
}
