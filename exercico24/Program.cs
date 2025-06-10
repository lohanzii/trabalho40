double litrosDeAgua, litrosDeSuco, litros;

Console.WriteLine("Digite a quantidade de litros de refresco que vc deseja fazer:");
litros = Convert.ToDouble(Console.ReadLine());

litrosDeAgua = litros * 0.80; // 80% de água
litrosDeSuco = litros * 0.20; // 20% de suco
Console.WriteLine("A quantidade de água necessária é: " + litrosDeAgua + " litros");
Console.WriteLine("A quantidade de suco necessária é: " + litrosDeSuco + " litros");
Console.WriteLine("A quantidade total de refresco é: " + litros + " litros");
