decimal distancia, x, y;

Console.WriteLine("Digite a coordenada X do ponto A:");
x = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a coordenada Y do ponto A:");
y = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a coordenada X do ponto B:");
decimal x2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a coordenada Y do ponto B:");
decimal y2 = Convert.ToDecimal(Console.ReadLine());

distancia = Math.Sqrt(Math.Pow(x2 - x * 2) + Math.Pow(y2 - y * 2));