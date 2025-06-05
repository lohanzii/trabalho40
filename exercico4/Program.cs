int dias = 365, anos;
string nome;

Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();

Console.WriteLine("Digite sua idade");
anos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" " + nome + " , você ja viveu " + dias * anos + " de dias");
