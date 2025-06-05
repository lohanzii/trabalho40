decimal  salarioAtual, valorAumento, valorDescontado, salarioFinal;

Console.WriteLine("Digite o salário atual do funcionário:");
salarioAtual = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor do aumento:");
valorAumento = Convert.ToDecimal(Console.ReadLine());
valorAumento /= 100; // Convertendo o aumento percentual para decimal

Console.WriteLine("Digite o valor do desconto:");
valorDescontado = Convert.ToDecimal(Console.ReadLine());
valorDescontado /= 100; // Convertendo o desconto percentual para decimal

salarioFinal = salarioAtual + (salarioAtual * valorAumento) - (salarioAtual * valorDescontado);
Console.WriteLine("O salário final do funcionário é: " + salarioFinal.ToString("C2"));
// O comando ToString("C2") formata o valor como moeda, com duas casas decimais.


