int camisaP, camisaM, camisaG, valorArrecadado;

Console.WriteLine("Informe a quantidade de camisas P vendidas");
camisaP = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a quantidade de camisas M vendidas");
camisaM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a quantidade de camisas G vendidas");
camisaG = Convert.ToInt32(Console.ReadLine());

valorArrecadado = (camisaP * 10) + (camisaM * 12) + (camisaG * 15);
Console.WriteLine("O valor arrecadado com a venda de camisas é: R$ " + valorArrecadado);