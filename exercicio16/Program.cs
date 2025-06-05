int sanduiches;

Console.WriteLine("Informe quantos sanduiches você quer fazer");
sanduiches = Convert.ToInt32(Console.ReadLine());

int queijo = sanduiches * 2;
int presunto = sanduiches;
int hamburguers = sanduiches;
Console.WriteLine("Para fazer " + sanduiches + " sanduiches, você vai precisar de:");
decimal queijoEmKg = queijo * 0.05m; // 50g de queijo por sanduíche
decimal presuntoEmKg = presunto * 0.05m; // 50g de presunto por sanduíche
decimal hamburguerEmKg = hamburguers * 0.1m; // 100g de hambúrguer por sanduíche
Console.WriteLine(queijo + " fatias de queijo, o que equivale a " + queijoEmKg + " kg de queijo");
Console.WriteLine(presunto + " fatias de presunto, o que equivale a " + presuntoEmKg + " kg de presunto");
Console.WriteLine(hamburguers + " hambúrgueres, o que equivale a " + hamburguerEmKg + " kg de hambúrguer");
