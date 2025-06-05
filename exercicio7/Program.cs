int dia, mes, totalDias;

Console.WriteLine("Informe o dia");
dia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o mês");
mes = Convert.ToInt32(Console.ReadLine());

totalDias = mes * 30 + dia;
Console.WriteLine("Ja se passaram " + totalDias + " desde o incio do ano");

