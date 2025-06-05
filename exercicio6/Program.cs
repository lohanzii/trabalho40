decimal valorPorQuilo, pesoPrato = 0, valorPago, pesoPratoMontado = 0;

Console.WriteLine("Digite o valor cobrado por quilo de alimento");
valorPorQuilo = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o peso do prato");
pesoPrato = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o peso do prato montado");
pesoPratoMontado = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Descontando o peso do prato, o peso dele montado e de: " + pesoPratoMontado);

