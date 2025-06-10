int anoNascido, anoAtual, dia, mes, semana, idade;

Console.WriteLine("Digite o ano de nascimento:");
anoNascido = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o ano atual:");
anoAtual = Convert.ToInt32(Console.ReadLine());

idade = anoAtual - anoNascido;

Console.WriteLine("A idade é: " + idade + " anos");
Console.WriteLine("A idade em dias é: " + (idade * 365) + " dias");
Console.WriteLine("A idade em meses é: " + (idade * 12) + " meses");
Console.WriteLine("A idade em semanas é: " + (idade * 52) + " semanas");


