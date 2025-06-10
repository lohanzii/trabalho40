double salarioMinimo, salarioFuncionario, quaintidadeSalarios;

Console.WriteLine("Digite o valor do salário mínimo:");
salarioMinimo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o salário do funcionário:");
salarioFuncionario = Convert.ToDouble(Console.ReadLine());

quaintidadeSalarios = salarioFuncionario / salarioMinimo;
Console.WriteLine("O funcionário recebe " + quaintidadeSalarios + " salários mínimos.");