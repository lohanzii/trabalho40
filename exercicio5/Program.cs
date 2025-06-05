decimal valorGasolina, litros, valor;

Console.WriteLine("Digite o valor que você quer colocar de gasolina");
valor = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor do litro do gasolina");
valorGasolina = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Foram abastecido " + valor / valorGasolina + " de litros");