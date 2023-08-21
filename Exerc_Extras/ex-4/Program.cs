int culpa = 0;

Console.WriteLine($"voce ligou para a vitima?");

string r1 = Console.ReadLine()!.ToLower();
if (r1 == "sim")
{
    culpa++;
}

Console.WriteLine($"Esteve no local do crime?");
string r2 = Console.ReadLine()!.ToLower();
if (r2 == "sim")
{
    culpa += 1;
}

Console.WriteLine($"Mora perto da vítima?");
string r3 = Console.ReadLine()!.ToLower();
if (r3 == "sim")
{
    culpa += 1;
}

Console.WriteLine($"Devia para a vítima?");
string r4 = Console.ReadLine()!.ToLower();
if (r4 == "sim")
{
    culpa += 1;
}

Console.WriteLine($"Já trabalhou com a vítima?");
string r5 = Console.ReadLine()!.ToLower();
if (r5 == "sim")


{
    culpa += 1;
}
if (culpa < 2)
{
    Console.WriteLine($"Você está classificado como Inocente.");

}
else if (culpa == 2)
{
    Console.WriteLine($"Você está classificado como suspeito.");

}
else if (culpa == 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"VOCÊ É O ASSASSINO");
    Console.ResetColor();

}
else
{
    Console.WriteLine($"Você é um cúmplice");
}

