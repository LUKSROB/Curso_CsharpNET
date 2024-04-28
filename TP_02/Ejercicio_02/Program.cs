Console.WriteLine("Ejercicio 02: Pide un número entero positivo e imprime los numeros pares hasta ese número.");
Console.WriteLine("Escribe un numero entero positivo");

int i = int.Parse(Console.ReadLine());
int num = (i % 2 == 0) ? i : i - 1;

if (i > 0)
{
    Console.WriteLine("Los numeros pares hasta " + num + " son:");
    for (int l = 2; l <= num; l += 2)
    {
        Console.WriteLine(l);
    }
}