// See https://aka.ms/new-console-template for more information

using operaciones_aritmeticas;

Console.WriteLine("operaciones aritmeticas");
Console.WriteLine();


int resultado_suma, resultado_resta, resultado_multiplica;

Suma suma = new Suma();
Console.WriteLine("operacion suma");
Console.WriteLine();
Console.Write("Valor 1: ");
suma.valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Valor 2: ");
suma.valor2 = Convert.ToInt32(Console.ReadLine());
resultado_suma = suma.operar();
Console.WriteLine($"El resultado de la suma es {resultado_suma}");
Console.WriteLine();

Resta resta = new Resta();
Console.WriteLine("operacion resta");
Console.WriteLine();
Console.Write("Valor 1: ");
resta.valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Valor 2: ");
resta.valor2 = Convert.ToInt32(Console.ReadLine());
resultado_resta = resta.operar();
Console.WriteLine($"El resultado de la resta es {resultado_resta}");
Console.WriteLine();

Multiplicacion multiplicacion = new Multiplicacion();
Console.WriteLine("operacion multiplicacion");
Console.WriteLine();
Console.Write("Valor 1: ");
multiplicacion.valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Valor 2: ");
multiplicacion.valor2 = Convert.ToInt32(Console.ReadLine());
resultado_multiplica =multiplicacion.operar();
Console.WriteLine($"El resultado de la suma es {resultado_multiplica }");
Console.WriteLine();


