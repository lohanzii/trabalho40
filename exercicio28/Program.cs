double nota1, nota2, mediaPonderada;

Console.WriteLine("Digite a primeira nota (peso 2):");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a segunda nota (peso 3):");
nota2 = Convert.ToDouble(Console.ReadLine());

mediaPonderada = (nota1 * 2 + nota2 * 3) / (2 + 3);
Console.WriteLine("A média ponderada é: " + mediaPonderada);