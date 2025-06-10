double salario, C1, C2, salaioFinal, multaConta1, multaConta2;

Console.WriteLine("Digite o salário do João:");
salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor da primeira conta:");
C1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor da segunda conta:");
C2 = Convert.ToDouble(Console.ReadLine());

multaConta1 = C1 * 0.02; // 2% de multa
multaConta2 = C2 * 0.02; // 2% de multa
salaioFinal = salario - (C1 + C2 + multaConta1 + multaConta2);
Console.WriteLine("O salário final do João é: " + salaioFinal);


