Console.WriteLine("Ejercicio 03: Pide un precio y lo muestra con 10% de descuento.");
Console.WriteLine("Escribe un precio");

float price = float.Parse(Console.ReadLine());
float discount = price * 0.1f;

Console.WriteLine("El precio con descuento es " + (price - discount));