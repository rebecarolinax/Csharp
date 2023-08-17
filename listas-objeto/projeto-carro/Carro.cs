namespace projeto_carro
{
    public class Carro
    {
        //propriedades:
        public string Marca { get; set; }
        public string Cor { get; set; }


        //métodos:

        public Carro() //vazio
        {

        }

        public Carro(string marca, string cor) //completa
        {
            Marca = marca;
            Cor = cor;
        }
    }
}