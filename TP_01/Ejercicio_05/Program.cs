Console.WriteLine("Ejercicio 05: Pide una respuesta de true o false y la muestra.");
Console.WriteLine("Tu respuesta es true o false?");  

bool response = bool.Parse(Console.ReadLine());

Console.WriteLine(response ? "Tu respuesta es afirmativa" : "Tu respuesta es negativa");