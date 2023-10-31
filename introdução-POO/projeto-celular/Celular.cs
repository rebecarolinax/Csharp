namespace projeto_celular
{
    public class Celular
    {
        public string Cor;
        public string Modelo;
        public string Tamanho;
        public bool Ligado;

        public void ligarCelular()
        {
            Console.WriteLine($"Seu celular está ligado!");
            Ligado = true;
        }
        public void desligarCelular()
        {
            Console.WriteLine($"Seu celular está desligado!");
            Ligado = false;
        }

        public void fazerLigacao(string destinatario)
        {
            if (Ligado == true)
            {
                Console.WriteLine($"Ligando para {destinatario}...");
            }
            else
            {
                Console.WriteLine($"Ligue seu Smartphone para fazer uma ligação.");
            }
        }
        public void enviarMensagem(string destinatario, string mensagem)
        {
            if (Ligado == true)
            {
                Console.WriteLine(@$"Enviando: 
                '{mensagem}'
                
                para: {destinatario}");
            }
            else
            {
                Console.WriteLine($"Ligue seu Smartphone para enviar uma mensagem.");
            }
        }
    }
}