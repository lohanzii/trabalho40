int cavalos, ferraduras;

Console.WriteLine("Imforme quantos cavalos tem no haras");
cavalos = Convert.ToInt32(Console.ReadLine());

ferraduras = cavalos * 4;
Console.WriteLine("São necessárias " + ferraduras + " ferraduras para " + cavalos + " cavalos ");
