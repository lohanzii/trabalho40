int frangos;
double precoFrango, precoChip = 4.50, precoAlimentos = 3.50, custoPorFrango, custoTotal;

Console.WriteLine("Digite o número de frangos:");
frangos = Convert.ToInt32(Console.ReadLine());

custoPorFrango = precoChip + (2 * precoAlimentos);
custoTotal = custoPorFrango * frangos;

Console.WriteLine("O custo por frango é: " + custoPorFrango);
Console.WriteLine("O custo total é: " + custoTotal);
Console.WriteLine("O custo total por frango é: " + (custoTotal / frangos));




