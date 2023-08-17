using projeto_produto;

List<Product> produtos = new List<Product>();

//primeira forma
produtos.Add(
    new Product(123, "Camiseta", 19.90f)
);

produtos.Add(
    new Product(321, "Tênis", 250.50f)
);

//segunda forma
Product calçaSkinny = new Product(789, "Calça Skinny", 27.90f);
produtos.Add(calçaSkinny);

foreach (var item in produtos)
{
    Console.WriteLine($@"
    Código: {item.Codigo}
    Nome: {item.Nome}
    Preço: {item.Preco}");
}


//update: 

Product produtoBuscado= produtos.Find(x => x.Codigo == 123)!;

int index = produtos.IndexOf(produtoBuscado);

produtoBuscado.Preco = 199.90f;

produtos.RemoveAt(index);

produtos.Insert(index,produtoBuscado);

foreach (var item in produtos)
{
    Console.WriteLine($@"
    Código: {item.Codigo}
    Nome: {item.Nome}
    Preço: {item.Preco}");
}