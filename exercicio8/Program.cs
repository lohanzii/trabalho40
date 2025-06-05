decimal nota1, nota2, nota3, media;

Console.WriteLine("Digite a primeira nota");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a segunda nota");
nota2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a terceira nota");
nota3 = Convert.ToDecimal(Console.ReadLine());

media = nota1 + nota2 + nota3 / 3;
Console.WriteLine("A média do aluno é: " + media);
