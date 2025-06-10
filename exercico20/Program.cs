int quantidadeBlusas, novelos;

Console.WriteLine("Digite a quantidade de blusas:");
quantidadeBlusas = Convert.ToInt32(Console.ReadLine());

novelos = quantidadeBlusas * 3; // Cada blusa requer 3 novelos de lã

Console.WriteLine("A quantidade de novelos de lã necessária é: " + novelos);
Console.WriteLine("A quantidade de novelos de lã necessária por blusa é: " + (novelos / quantidadeBlusas));

