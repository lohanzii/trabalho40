decimal tempCelsius, tempFahrenheit;

Console.WriteLine("Digite a temperatura em Celsius:");
tempCelsius = Convert.ToDecimal(Console.ReadLine());

tempFahrenheit = (tempCelsius * 9 / 5) + 32;
Console.WriteLine("A temperatura em Fahrenheit é: " + tempFahrenheit + "°F");
//A formula de conversão de Celsius para Fahrenheit é: F = C * 9/5 + 32