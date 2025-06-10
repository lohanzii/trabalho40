int um, cino, dez, vintecinco, cinquenta, real;
double total;

Console.WriteLine("Digite a quantidade de moedas de 1 centavo:");
um = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a quantidade de moedas de 5 centavos:");
cino = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a quantidade de moedas de 10 centavos:");
dez = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a quantidade de moedas de 25 centavos:");
vintecinco = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a quantidade de moedas de 50 centavos:");
cinquenta = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a quantidade de moedas de 1 real:");
real = Convert.ToInt32(Console.ReadLine());

total = (um * 0.01) + (cino * 0.05) + (dez * 0.10) + (vintecinco * 0.25) + (cinquenta * 0.50) + (real * 1.00);
Console.WriteLine("O total em dinheiro é: R$ " + total.ToString("F2"));
// to.String("F2") é usado para formatar o número com duas casas decimais, representando centavos.