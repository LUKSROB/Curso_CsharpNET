Console.WriteLine("Ejercicio 10: Pide un número de teléfono y muestra si es válido");
Console.WriteLine("Escribe un número de teléfono");

string phoneNumber = Console.ReadLine();

Console.WriteLine(phoneNumber.Length == 10 ? "Número de teléfono válido" : "Número de teléfono inválido");