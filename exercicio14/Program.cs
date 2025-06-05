decimal pi = 3.14m, R;
//Para calcular a área do círculo, utilizamos a fórmula A = π * R², onde A é a área, π é o valor de pi e R é o raio do círculo.

Console.WriteLine("Digite o valor do R (raio): ");
R = decimal.Parse(Console.ReadLine());
// O comando decimal.Parse() converte uma string em um número decimal.
Console.WriteLine("A área do círculo é: " + (pi * R * R));

