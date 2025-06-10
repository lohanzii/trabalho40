double numero1, numero2, total;

Console.WriteLine("Digite o primeiro número:");
numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo número (NÃO PODE SER ZERO):");
numero2 = Convert.ToDouble(Console.ReadLine());

total = numero1 / numero2;
Console.WriteLine("A divisão dos dois números é: " + total);
