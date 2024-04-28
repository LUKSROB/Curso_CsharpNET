Console.WriteLine("Ejercicio 04: Pide la edad de una persona y muestra si es mayor de edad.");
Console.WriteLine("Escribe tu edad");   

int age = int.Parse(Console.ReadLine());

Console.WriteLine(age >= 18 ? "Eres mayor de edad" : "Eres menor de edad");