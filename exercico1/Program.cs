decimal lagura, comprimento, areaTotal;

Console.WriteLine("Digite a largura do terreno");
lagura = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o comrpimento");
comprimento = Convert.ToInt32(Console.ReadLine());

areaTotal = comprimento * lagura;
Console.WriteLine("A area total do terreno é " + areaTotal + " m²");