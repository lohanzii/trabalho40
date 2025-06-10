int horasNormais, HorasExtras;
double salarioBruto, salarioLiquido, desconto;

Console.WriteLine("Digite o número de horas trabalhadas:");
horasNormais = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o número de horas extras trabalhadas:");
HorasExtras = Convert.ToInt32(Console.ReadLine());

salarioBruto = (horasNormais * 10) + (HorasExtras * 15);

desconto = salarioBruto * 0.1; // 10% de desconto

salarioLiquido = salarioBruto - desconto;

Console.WriteLine("O salário bruto é: " + salarioBruto);
Console.WriteLine("O desconto é: " + desconto);
Console.WriteLine("O salário líquido é: " + salarioLiquido);






