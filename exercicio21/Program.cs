int quantidadeLatinhas, quantidadeGarrafas, quantidadeGarrafões;
double ValumeGarrafas = 0.600, VolumeGarrafões = 2, VolumeLatinhas = 0.350, volumeTotal;

Console.WriteLine("Digite a quantidade de latinhas:");
quantidadeLatinhas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de garrafas:");
quantidadeGarrafas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de garrafões:");
quantidadeGarrafões = Convert.ToInt32(Console.ReadLine());

volumeTotal = (quantidadeLatinhas * VolumeLatinhas) + (quantidadeGarrafas * ValumeGarrafas) + (quantidadeGarrafões * VolumeGarrafões);
Console.WriteLine("O volume total é: " + volumeTotal + " litros");
