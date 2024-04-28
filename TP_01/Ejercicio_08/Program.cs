Console.WriteLine("Ejercicio 08: Pide el radio de un círculo y muestra el área.");
Console.WriteLine("Escribe el radio de un círculo");

double radius = double.Parse(Console.ReadLine());
double area = Math.PI * Math.Pow(radius, 2);

Console.WriteLine("El área del círculo es: " + area);