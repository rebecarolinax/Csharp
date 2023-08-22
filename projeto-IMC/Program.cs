// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine(@$"
---------------------------
|  Programa               |
|  para calcular IMC      |
---------------------------
");
Console.ResetColor();

Console.WriteLine($"Digite o nome do paciente");
string nome = Console.ReadLine();

Console.WriteLine($"Digite o peso do paciente");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a altura do paciente");
float altura = float.Parse (Console.ReadLine());

float imc = (peso / ((float)Math.Pow(altura,2)));

Console.WriteLine($"O paciente {nome} tem imc igual á {imc}");

Console.WriteLine($"Obrigada por utilizar nosso sistema !");
