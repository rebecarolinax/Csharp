Console.WriteLine($"Digite o dia do seu aniversário?");
int dia = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o mes do seu aniversário?");
int mes = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o ano do seu aniversário?");
int ano = int.Parse(Console.ReadLine()!);

if (dia > 31)
{
    Console.WriteLine($"A data é inválida. o mes possui 31 dias");
    
}

else if (mes > 12)
{
    Console.WriteLine($"A data é inválida. o ano possui 12 meses");
    
}

else if (ano > 2013)
{
    Console.WriteLine($"A data é inválida. estamos em 2013");
    
}

else {
    Console.WriteLine($"A data é válida");
    
}