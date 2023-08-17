Console.WriteLine($"Digite a quantidade  de aulas do aluno:");
int quantAulas = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite a quantidade  de presença do aluno:");
float frequencia = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite a nota do aluno:");

float porcentagem = frequencia * 100/quantAulas;

int nota = int.Parse(Console.ReadLine()!);

if(frequencia < 75){
    Console.WriteLine($"Aluno Reprovado");
}else if(frequencia > 75 && nota < 7 ){
    Console.WriteLine($"Aluno de recuperação");
    
}
else if(frequencia > 75 && nota < 3){
    Console.WriteLine($"Aluno Reprovado");
}else{
    Console.WriteLine($"Aluno aprovado");
    
}

