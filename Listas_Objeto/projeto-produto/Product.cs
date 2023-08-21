namespace projeto_produto
{
    public class Product
    {
        public int Codigo { get; set; }
        public float Preco { get; set; }
        public string Nome { get; set; }

        public Product(int codigo, string nome, float preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
    }
}
