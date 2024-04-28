Console.WriteLine("Ejercicio 08: Pide las horas trabajadas y devuelve el salario diario.");
Console.WriteLine("Escribe las horas trabajadas");

int hours = int.Parse(Console.ReadLine());
int salary = hours * 10;

Console.WriteLine("Tu salario diario es: " + salary);