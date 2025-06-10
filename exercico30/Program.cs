double salario, comissao = 0.04, vendas, salarioFinal;

Console.WriteLine("Digite o salário fixo do vendedor:");
salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o total de vendas do vendedor:");
vendas = Convert.ToDouble(Console.ReadLine());

salarioFinal = salario + (vendas * comissao);
Console.WriteLine("O salário final do vendedor é: " + salarioFinal);
