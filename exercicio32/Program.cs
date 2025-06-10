double pesoEmKg, pesoEmGramas;

Console.WriteLine("Digite o peso em quilogramas (kg):");
pesoEmKg = Convert.ToDouble(Console.ReadLine());
pesoEmGramas = pesoEmKg * 1000; // 1 kg = 1000 gramas
Console.WriteLine("O peso em gramas é: " + pesoEmGramas + " g");
