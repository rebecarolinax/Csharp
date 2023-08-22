namespace projeto_aluno
{
    public class CadastrarAluno
    {
        //declarando perguntas tipo string:
        public string PerguntaString(string pergunta)
        {
            Console.WriteLine(pergunta);
            return Console.ReadLine()!;
        }

        //declarando perguntas tipo char:
        public char PerguntaChar(string pergunta)
        {
            Console.WriteLine(pergunta);
            return char.Parse(Console.ReadLine()!);
        }

        //declarando perguntas tipo int:
        public int PerguntaInt(string pergunta)
        {
            Console.WriteLine(pergunta);
            return int.Parse(Console.ReadLine()!);
        }

        //declarando perguntas tipo float:
        public float PerguntaFloat(string pergunta)
        {
            Console.WriteLine(pergunta);
            return float.Parse(Console.ReadLine()!);
        }

        ////exibir mensagem quando dada a função (sem retorno):
        static void ExibirTexto(string texto)
        {
            Console.WriteLine(texto);
        }

        static void ExibeMensagem(string texto)
        {
            Console.Write(texto);
        }
        //exibir mensagem quando dada a função (sem retorno)
        public string Nome;
        public string Curso;
        public string Idade;
        public string Rg;
        public bool Bolsista = false;
        public float MediaFinal;
        public float ValorMensalidade;

        public void VerMediaFinal()
        {
            ExibirTexto(@$"A média final do {this.Nome} é igual a : {this.MediaFinal}");
        }

        public void VerMensalidade()
        {
            if (Bolsista && MediaFinal >= 8)
            {
                ExibirTexto(@$"O valor a pagar da mensalidade para o aluno {this.Nome} é de 50% do valor {this.ValorMensalidade}, totalizando em: R${this.ValorMensalidade * 0.50}");
            }
            else if (Bolsista && (MediaFinal >= 6 && MediaFinal < 8))
            {
                ExibirTexto(@$"O valor a pagar da mensalidade para o aluno {this.Nome} é de 70% do valor {this.ValorMensalidade}, totalizando em: R${this.ValorMensalidade * 0.70}");
            }
            else
            {
                ExibirTexto(@$"O valor a pagar da mensalidade para o aluno {this.Nome} é de 100% do valor {this.ValorMensalidade}, totalizando em: R${this.ValorMensalidade}");
            }
        }
    }
}
