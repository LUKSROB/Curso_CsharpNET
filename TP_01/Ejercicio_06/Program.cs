Console.WriteLine("Ejercicio 07: Pide una fecha y muestra el día de la semana.");
Console.WriteLine("Escribe una fecha (dd/mm/yyyy)");

DateTime date = DateTime.Parse(Console.ReadLine());

Console.WriteLine("El día de la semana es: " + date.DayOfWeek);