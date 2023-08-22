int[] numeros = new int[10];
int menorNumero = 0;
int maiorNumero = 0; 

Console.WriteLine("Informe 10 valores:");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1}º valor:");
    numeros[i] = int.Parse(Console.ReadLine()!);

    if (i == 0)
    {
        menorNumero = numeros[0];
        maiorNumero = numeros[0];
    }

    if (numeros[i] < menorNumero)
    {
        menorNumero = numeros[i];
    
    }
    else if (numeros[i] > maiorNumero)
    {
        maiorNumero = numeros[i];
    
    }

}
Console.WriteLine($"O menor número é {menorNumero}");
Console.WriteLine($"O maior número é {maiorNumero}");
