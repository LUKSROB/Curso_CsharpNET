Console.WriteLine("Ejercicio 01: Pide un numero entero positivo y suma los numeros pares menores o iguales a el.");
Console.WriteLine("Escribe un numero entero positivo");

int i = int.Parse(Console.ReadLine());
int num = (i % 2 == 0) ? i : i - 1;
int sum = 0;

if (i > 0)
{
    for (int l = 0; l <= num; l += 2)
    {
        sum += l;
    }
    Console.WriteLine("La suma de los numeros pares menores o iguales a " + i + " es " + sum);
}