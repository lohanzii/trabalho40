int QuantidadePaes, QuantidadeBroas, valorTotal;
decimal valorBroas, valorPao;

Console.WriteLine("Informe a quantidade de pães:");
QuantidadePaes = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a quantidade de broas:");
QuantidadeBroas = int.Parse(Console.ReadLine());
//O comando int.Parse converte o valor lido como string para inteiro

valorPao = 0.12m;
valorBroas = 1.50m;
valorTotal = (int)(QuantidadePaes * valorPao + QuantidadeBroas * valorBroas);
Console.WriteLine($"Valor total da compra: R$ {valorTotal}");
