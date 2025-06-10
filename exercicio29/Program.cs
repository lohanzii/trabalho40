double precoProduto, desconto = 0.10, precoComDesconto;

Console.WriteLine("Digite o preço do produto:");
precoProduto = Convert.ToDouble(Console.ReadLine());

precoComDesconto = precoProduto - (precoProduto * desconto);
Console.WriteLine("O preço do produto com desconto é: " + precoComDesconto);