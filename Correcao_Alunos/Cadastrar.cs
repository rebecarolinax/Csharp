namespace correcao_alunos
{
    public class Cadastrar
    {
        //características ou propriedades:
        public string Nome;
        public string Curso;
        public string Idade;
        public string Rg;
        public bool Bolsista;
        public float MediaFinal;
        public float ValorMensalidade;

        //métodos e funções:
        public void VerMediaFinal()
        {
            Console.WriteLine(@$"A média final do {this.Nome} é igual a : {this.MediaFinal}");
        }

        public void VerMensalidade()
        {
            if (this.Bolsista == true && this.MediaFinal >= 8)
            {
                Console.WriteLine($"O valor a pagar da mensalidade para o aluno {this.Nome} é de 50% do valor {this.ValorMensalidade}, totalizando em: R${this.ValorMensalidade * 0.5f}");
            }

            else if (this.Bolsista == true && this.MediaFinal > 6)
            {
                Console.WriteLine($"O valor a pagar da mensalidade para o aluno {this.Nome} é de 70% do valor {this.ValorMensalidade}, totalizando em: R${this.ValorMensalidade * 0.70}");
            }

            else
            {
                Console.WriteLine($"O valor a pagar da mensalidade para o aluno {this.Nome} é de 100% do valor {this.ValorMensalidade}, totalizando em: R${this.ValorMensalidade}");
            }
        }

    }
}