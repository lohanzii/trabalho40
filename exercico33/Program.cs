double baseMaior, baseMenor, altura, areaTrapezio;

Console.WriteLine("Digite a base maior do trapézio:");
baseMaior = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a base menor do trapézio:");
baseMenor = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a altura do trapézio:");
altura = Convert.ToDouble(Console.ReadLine());

areaTrapezio = ((baseMaior + baseMenor) * altura) / 2;
Console.WriteLine("A área do trapézio é: " + areaTrapezio + " m²");
// Para calcular a área de um trapézio, usamos a fórmula: (baseMaior + baseMenor) * altura) / 2