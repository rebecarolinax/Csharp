Console.WriteLine($"Bem vindo! Por favor digite o raio do círculo:");
float raio = float.Parse(Console.ReadLine()!);
float diametro = (raio + raio);
double area = Math.Round((Math.PI * (raio * raio)), 2);

Console.WriteLine($"Bom, se seu círculo possui esse raio, seu diâmetro é de {diametro} e sua área é de {area}");