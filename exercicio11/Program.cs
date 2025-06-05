int hora, dias, mes, ano;

Console.WriteLine("Informe a quantidade de hora que ficaram sem acidente");
hora = Convert.ToInt32(Console.ReadLine());

dias = hora / 24;

mes = dias / 30;

ano = mes / 12;

Console.WriteLine("A quantidade de dias sem acidente é: " + dias);
Console.WriteLine("A quantidade de meses sem acidente é: " + mes);
Console.WriteLine("A quantidade de anos sem acidente é: " + ano);
Console.WriteLine("A quantidade de horas sem acidente é: " + hora);