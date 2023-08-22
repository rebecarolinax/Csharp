Console.WriteLine($"Digite o lado 1 do triângulo:");
float lado1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o lado 2 do triângulo:");
float lado2 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o lado 3 do triângulo:");
float lado3 = float.Parse(Console.ReadLine()!);

if(lado1 == lado2 && lado3 == lado1){
    Console.WriteLine($"É um triângulo equilátero");
}
else if(lado1 != lado2 && lado2 != lado3 && lado3 == lado1){
    Console.WriteLine($"É um triângulo isóseles");
    
}else{
    Console.WriteLine($"É um triângulo escaleno");
}