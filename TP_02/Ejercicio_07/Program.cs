Console.WriteLine("Ejercicio 07: Pide un número entero positivo y muestra su tabla de multiplicar.");
Console.WriteLine("Escribe un numero entero positivo");

int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(num + " x " + i + " = " + num * i);
    }
}