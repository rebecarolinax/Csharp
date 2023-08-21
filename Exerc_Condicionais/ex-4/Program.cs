
Console.WriteLine($"Digite a sua senha:");
int senha = int.Parse(Console.ReadLine()!);

if ( senha != 1234 )
{
    Console.WriteLine($"Senha Inválida");
}

else if ( senha == 1234)
{
    Console.WriteLine($"Senha Válida");
}

