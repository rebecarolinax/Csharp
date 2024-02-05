Console.WriteLine($"Por favor, digite o caractere a ser informado:");
string a =Console.ReadLine()!.ToLower();
if (a == "a" || a == "e" || a == "i" || a == "o" || a == "u")
{
    Console.WriteLine($"Seu caractere é uma vogal!");
}
else
{
    Console.WriteLine($"Seu caractere é uma consoante");
}
