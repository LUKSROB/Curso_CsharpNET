Console.WriteLine("Ejercicio 06: Pide un número entero positivo y muestra su factorial.");
Console.WriteLine("Escribe un numero entero positivo");

int num = int.Parse(Console.ReadLine());
int factorial = 1;

if (num > 0)
{
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    Console.WriteLine("El factorial de " + num + " es " + factorial);
}