namespace construtores
{
    public class Produto
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        // public Produto()
        // { 

        // }

        public Produto(string codigo)
        {
            Codigo = codigo;
        }
        public Produto(string codigo, string nome, float preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
    }
}
