double altura,distanciaHorizontal, angulo;

Console.WriteLine("Digite a sua altura:");
altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a distância horizontal até a base do prédio :");
distanciaHorizontal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o ângulo de elevação do olhar (em graus):");
angulo = Convert.ToDouble(Console.ReadLine());
double alturaPredio = altura + (distanciaHorizontal * Math.Tan(angulo * Math.PI / 180));
// A altura do prédio é calculada usando a fórmula: alturaPredio = altura + (distanciaHorizontal * Math.Tan(angulo em radianos))
// A função Math.Tan espera o ângulo em radianos, então convertemos de graus para radianos multiplicando por Math.PI / 180.
// math.Tan é a função tangente da biblioteca Math do C#.
// math.PI é uma constante que representa o valor de pi (aproximadamente 3.14159).
Console.WriteLine("A altura do prédio é: " + alturaPredio + " metros");



