Console.WriteLine($"Digite o seu nome");
string name = Console.ReadLine();

while (name.Length == 0)
{
    Console.WriteLine($"Digite o seu nome novamente");
    name = Console.ReadLine();

}

Console.WriteLine($"Digite a sua idade");
int idade = int.Parse(Console.ReadLine());

while (idade < 0 || idade > 100)
{
    Console.WriteLine($"Digite uma idade válida");
    idade = int.Parse(Console.ReadLine());

}

Console.WriteLine($"Digite o seu sálario");
float salario = float.Parse(Console.ReadLine());

while (salario <= 0)
{
    Console.WriteLine($"Digite um salário válido");
    salario = float.Parse(Console.ReadLine());

}

Console.WriteLine($@"Informe seu estado civil: Digite: (s) para Solteiro(a)
(c) para Casado(a)
(v) para Viúvo(a)
(d) para Divorciado(a)");
char civil = char.Parse(Console.ReadLine().ToLower());

while (civil != 's' && civil != 'c' && civil != 'v' && civil != 'd')
{
    Console.Write($"Digite um estado civil válido:");
    civil = char.Parse(Console.ReadLine());
}

Console.WriteLine($"Seu cadastro foi concluído com sucesso, obrigada!");