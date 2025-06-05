int centena, dezena, unidade;

Console.WriteLine("Digite um número de 3 dígitos: ");
string numero = Console.ReadLine();

Console.WriteLine(centena = int.Parse(numero[0].ToString()));
Console.WriteLine(dezena = int.Parse(numero[1].ToString()));
Console.WriteLine(unidade = int.Parse(numero[2].ToString()));

// O comando int.Parse() converte uma string em um número inteiro.