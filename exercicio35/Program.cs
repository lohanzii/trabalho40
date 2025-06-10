double diagonalMaior, diagonalMenor, areaLosango;

Console.WriteLine("Digite o comprimento da diagonal maior do losango (em metros):");
diagonalMaior = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o comprimento da diagonal menor do losango (em metros):");
diagonalMenor = Convert.ToDouble(Console.ReadLine());

areaLosango = (diagonalMaior * diagonalMenor) / 2; // Área do losango = (d1 * d2) / 2
Console.WriteLine("A área do losango é: " + areaLosango + " m²");
// Para calcular a área de um losango, usamos a fórmula: (diagonalMaior * diagonalMenor) / 2