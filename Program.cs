Console.WriteLine("Média 4 Notas");
double nota1, nota2, nota3, nota4, notafinal;

Console.WriteLine("Digite sua primeira nota:...");
nota1 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite sua segunda nota:...");
nota2 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite sua terceira nota:...");
nota3 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite sua quarta nota:...");
nota4 = Convert.ToDouble(Console.ReadLine()!);

if(nota1 < 0 | nota1 > 10 | nota2 < 0 | nota2 > 10 | nota3 < 0 | nota3 > 10 | nota4 < 0 | nota4 > 10){
    Console.WriteLine("Digite somente notas de 0 a 10");
}
else{
      notafinal = (nota1 + nota2 + nota3 + nota4) / 4;

    if(notafinal > 6){
        Console.WriteLine($"Você ficou com média {notafinal}. Resultado : Aprovado! ");
    }
else if(notafinal < 5 ){
    Console.WriteLine($"Você ficou com média {notafinal}. Resultado: Reprovado! ");
}
else{
    Console.WriteLine($"Você ficou com média {notafinal}. Resultado: Em recuperação!");
}
}