using projeto_carro;

List<Carro> carros = new List<Carro>();

Console.WriteLine($"Digite a marca do primeiro carro:");
string marcaUm = Console.ReadLine()!;

Console.WriteLine($"Digite a cor do primeiro carro:");
string corUm = Console.ReadLine()!;

Console.WriteLine($"Digite a marca do segundo carro:");
string marcaDois = Console.ReadLine()!;

Console.WriteLine($"Digite a cor do segundo carro:");
string CorDois = Console.ReadLine()!;

carros.Add(
    new Carro(marcaUm, corUm)
);

carros.Add(
    new Carro(marcaDois, CorDois)
);

foreach (var item in carros)
{
    Console.WriteLine($@"
    Marca: {item.Marca}
    Cor: {item.Cor}
    ");

}