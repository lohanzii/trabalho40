double x1, y1, x2, y2, distancia;

Console.WriteLine("Digite as coordenadas do primeiro ponto x:");
x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite as coordenadas do primeiro ponto y:");
y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite as coordenadas do segundo ponto x:");
x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite as coordenadas do segundo ponto y:");
y2 = Convert.ToDouble(Console.ReadLine());

distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine("A distância entre os dois pontos é: " + distancia + " unidades");
// A distância entre dois pontos (x1, y1) e (x2, y2) é calculada pela fórmula:
// distância = √((x2 - x1)² + (y2 - y1)²)