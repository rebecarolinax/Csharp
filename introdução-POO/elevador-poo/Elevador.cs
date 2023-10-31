namespace elevador_poo
{
    public class Elevador
    {
        //propriedades:

        public int totalAndares;
        public int capacidadeTotal;
        public int quantPessoas;
        public int andarAtual;

        //métodos:

        public Elevador(int capacidadeTotal, int totalAndares)
        {
            this.andarAtual = 0;
            this.quantPessoas = 0;

            this.capacidadeTotal = capacidadeTotal;
            this.totalAndares = totalAndares;
        }

        public void Entrar()
        {
            Console.WriteLine($"Quantas pessoas vão entrar no elevador?");
            quantPessoas = int.Parse(Console.ReadLine()!);

            if (quantPessoas < 12)
            {
                Console.WriteLine($"Agora há {quantPessoas} pessoas no elevador.");
            }

            else
            {
                Console.WriteLine($"O elevador já atingiu o limite de capacidade!");
            }
        }

        public void Sair()
        {
            Console.WriteLine($"Quantas pessoas se encontram no elevador?");
            quantPessoas = int.Parse(Console.ReadLine()!);

            if (quantPessoas > 0)
            {
                quantPessoas--;
                Console.WriteLine($"Agora possuem {quantPessoas} no elevador.");
            }

            else
            {
                Console.WriteLine($"Inválido! Não foi possível retirar pessoas pois o elevador está vazio!");

            }
        }

        public void Subir()
        {
            Console.WriteLine($"Em qual andar se encontra o elevador?");
            andarAtual = int.Parse(Console.ReadLine()!);

            if (andarAtual < 15)
            {
                Console.WriteLine($"Informe quantos andares deseja subir:");
                int andares = int.Parse(Console.ReadLine()!);

                if (andarAtual + andares <= 15)
                {
                    Console.WriteLine($"O elevador se encontra no {andarAtual + andares}º andar.");
                }

                else
                {
                    Console.WriteLine($"Não é possível realizar essa ação!");
                }
            }

            else
            {
                Console.WriteLine($"Já estamos no ultímo andar!");
            }
        }


        public void Descer()
        {
            Console.WriteLine($"Em qual andar se encontra o elevador?");
            andarAtual = int.Parse(Console.ReadLine()!);

            if (andarAtual > 0)
            {
                Console.WriteLine($"Quando andares deseja descer?");
                int andares = int.Parse(Console.ReadLine()!);

                if (andarAtual - andares >= 0)
                {
                    Console.WriteLine(@$"O elevador agora se encontra no {andarAtual - andares}º andar.");
                }

                else
                {
                    Console.WriteLine($"Não é posível realizar essa ação!");
                }

            }

            else
            {
                Console.WriteLine($"Já estamos no terréo!");

            }
        }
    }
}
