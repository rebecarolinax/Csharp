﻿Console.WriteLine($"Por favor digite o primeiro número:");
float a = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Por favor digite o segundo número:");
float b = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Por favor digite o terceiro número:");
float c = float.Parse(Console.ReadLine()!);

if (a > b && b > c && a > c)
{
    Console.WriteLine($"O maior valor é {a} e o menor valor é {c}");
    
}
else if (b > a && a > c && b > c)
{
    Console.WriteLine($"O maior valor é {b} e o menor valor é {c}");
    
}
else if (a > c && c > b && a > b)
{
    Console.WriteLine($"O maior valor é {a} e o menor valor é {b}");
    
}
else if (b > c && c > a && b > a)
{
    Console.WriteLine($"O maior valor é {b} e o menor valor é {a}");
    
}
else if (c > b && b > a && c > a)
{
    Console.WriteLine($"O maior valor é {c} e o menor valor é {a}");
    
}
else if (c > a && a > b && c > b)
{
    Console.WriteLine($"O maior valor é {c} e o menor valor é {b}");
    
}
