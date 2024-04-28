Console.WriteLine("Ejercicio 03: Pide un número entero positivo y muestra la suma de sus digitos.");
Console.WriteLine("Escribe un numero entero positivo");

int num = int.Parse(Console.ReadLine());
int sum = 0;

if (num > 0)
{
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    Console.WriteLine("La suma de los digitos es " + sum);
}