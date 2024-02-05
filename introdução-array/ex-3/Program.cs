int pares = 0;
int impares = 0;
int zeros = 0;

int[] num = new int[6];

for (int i = 0; i < 6; i++)
{
    Console.Write($"Digite um número:");
    num[i] = int.Parse(Console.ReadLine()!);

    if ((num[i] % 2 == 0) && (num[i] > 0))
    {
        pares++;
    }
    else
    {
        impares++;
    }
}

foreach (int x in num)
{
    if (x % 2 == 0)
    {
        Console.WriteLine($"O número {x} é par");
        
    } else {
        Console.WriteLine($"O número {x} é impar");
        
    }
}

Console.WriteLine($"Há {pares} pares e {impares} impares");
