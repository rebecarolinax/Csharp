namespace ex1_poo
{
    public class Cafe
    {
        // propriedades: 
        public int acucarDisponivel = 500;

        //   métodos e funções:
        public void MaquinaCafe(int acucarDisponivel)
        {
            this.acucarDisponivel = acucarDisponivel;
        }

        public void FazerCafe()
        {
            Console.WriteLine($@"Deseja informar a quantidade de açúcar do seu café (em gramas)?
             (1)- Sim
             (2)- Não
             ");
            string escolha = Console.ReadLine()!.ToUpper();

            if (escolha == "1")
            {
                Console.WriteLine($"Quanto você gostaria?");
                int acucar = int.Parse(Console.ReadLine()!);

                if (acucar > acucarDisponivel)
                {
                    Console.WriteLine($@"Não temos essa quantidade disponível, mas colocaremos o que temos que equivale a {acucarDisponivel}g, você aceita?
                     (1)- Sim
                     (2)- Não
                     ");
                    string escolhaDois = Console.ReadLine()!.ToUpper();

                    if (escolhaDois == "1")
                    {
                        Console.WriteLine($"Entendido! Estamos preparando seu café?");
                    }

                    else
                    {
                        Console.WriteLine($"Compreendemos! Obrigado(a)");
                    }
                }

                else
                {
                    Console.WriteLine($"Entendido! Estamos preparando seu café");
                }
            }

            else
            {
                Console.WriteLine($@"Nosso sistema diciona por padrão 10g de açúcar quando o usuário não especifica a quantidade desejada, deseja seu café sem açúcar?
                (1)- Sim
                (2)- Não
                ");
                string respostaTres = Console.ReadLine()!.ToUpper();

                if (respostaTres == "1")
                {
                    Console.WriteLine($"Entendido! Estamos preparando seu café sem açúcar");
                }

                else
                {
                    Console.WriteLine($"Entendido! Estamos preparando seu café");

                }
            }



        }
    }
}