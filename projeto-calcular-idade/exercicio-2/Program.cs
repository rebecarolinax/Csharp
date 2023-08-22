// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//ATIVIDADE 2 PARA ENTREGAR

Console.WriteLine($"Digite o ano do seu nascimento:");
int anoInt = int.Parse(Console.ReadLine());

int anos = 2023 - anoInt;
Console.WriteLine($"sua idade é {anos}");

int semanas = anoInt * 50;
Console.WriteLine($"sua idade em semanas é {semanas}");

{
var data = DateTime.Now.Year;
Console.WriteLine(data);
}


