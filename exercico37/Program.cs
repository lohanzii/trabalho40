int tabuada, numero, resultado;

Console.WriteLine("Digite um número para ver a tabuada:");
tabuada = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Tabuada do " + tabuada + ":");
for (numero = 1; numero <= 10; numero++)
{
    resultado = tabuada * numero;
    Console.WriteLine(tabuada + " x " + numero + " = " + resultado);
}
Console.WriteLine("Tabuada do " + tabuada + " concluída.");
