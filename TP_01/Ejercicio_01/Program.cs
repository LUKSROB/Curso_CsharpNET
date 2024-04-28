Console.WriteLine("Ejercicio 01: Pide un número y lo multiplica por 2.");
Console.WriteLine("Escribe un numero");

string str = Console.ReadLine();
int num = int.Parse(str == null ? "0" : str);
int sum = num * 2;

Console.WriteLine("El numero multiplicado por 2 es " + sum);