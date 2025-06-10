double cateto1, cateto2, hipotenusa;

Console.WriteLine("Digite o comprimento do primeiro cateto:");
cateto1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o comprimento do segundo cateto:");
cateto2 = Convert.ToDouble(Console.ReadLine());

hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2)); // Teorema de Pitágoras
Console.WriteLine("O comprimento da hipotenusa é: " + hipotenusa + " metros");
// Para calcular a hipotenusa de um triângulo retângulo, usamos o Teorema de Pitágoras:
// hipotenusa = √(cateto1² + cateto2²)
// Onde cateto1 e cateto2 são os comprimentos dos catetos do triângulo retângulo.
// O resultado é a raiz quadrada da soma dos quadrados dos catetos.
// O comando Math.Sqrt() é usado para calcular a raiz quadrada,