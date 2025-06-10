double volume, raio, altura, pi = 3.14;

Console.WriteLine("Digite o raio da caixa d'água:");
raio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a altura da caixa d'água:");
altura = Convert.ToDouble(Console.ReadLine());

volume = pi * Math.Pow(raio, 2) * altura;
Console.WriteLine("O volume da caixa d'água é: " + volume + " metros cúbicos");
