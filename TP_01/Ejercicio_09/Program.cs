Console.WriteLine("Ejercicio 09: Pide la cantidad de productos vendidos y muestra si completó la cuota.");
Console.WriteLine("Escribe la cantidad de productos vendidos");

int soldProducts = int.Parse(Console.ReadLine());

Console.WriteLine(soldProducts >= 100 ? "Completó la cuota diaria" : "No completó la cuota diaria");