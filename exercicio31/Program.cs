double pesoNormal, pesoAcima, pesoAbaixo;

Console.WriteLine("Digite o seu peso:");
pesoNormal = Convert.ToDouble(Console.ReadLine());

pesoAcima = pesoNormal + (pesoNormal * 0.15); // 15% acima do peso normal

pesoAbaixo = pesoNormal - (pesoNormal * 0.20); // 20% abaixo do peso normal

Console.WriteLine("O peso normal é: " + pesoNormal + " kg");
Console.WriteLine("O peso acima do normal é: " + pesoAcima + " kg");
Console.WriteLine("O peso abaixo do normal é: " + pesoAbaixo + " kg");
