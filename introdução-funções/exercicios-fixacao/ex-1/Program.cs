//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto

//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda

bool valor = false;
while (valor == false)
{


    Console.WriteLine($"Informe a sua renda:");


    float renda = float.Parse(Console.ReadLine()!);
    static float CalculoImposto(float renda, float porcentagem)
    {
        return (porcentagem / 100 * renda);
    }

    if (renda <= 1500)
    {
        Console.WriteLine($"Você está isento de impostos!");

    }

    else if (renda <= 3500)
    {
        float results = CalculoImposto(renda, 20);
        Console.WriteLine($"O valor do seu imposto é R${results}");
    }

    else if (renda <= 6000)
    {
       float results = CalculoImposto(renda, 25);
        Console.WriteLine($"O valor do seu imposto é R${results}");
    }

    else if (renda > 6000)
    {
       float results = CalculoImposto(renda, 35);
        Console.WriteLine($"O valor do seu imposto é R${results}");
    }

    else 
    {
        Console.WriteLine($"Informe um salário válido");

    }
}







