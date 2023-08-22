Console.WriteLine($"Digite a quantidade de maçãs:");
int maça = int.Parse(Console.ReadLine()!);
float conta1 = maça * 0.25F;
float conta2 = maça * 0.30F;

if (maça >= 12)
{
    Console.WriteLine($"O preço da maçã é {conta1}");
}
else
{
    Console.WriteLine($"O preço da maçã é {conta2}");
}
