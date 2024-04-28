Console.WriteLine("Ejercicio 05: Pide un número y muestra la secuencia de Fibonacci hasta ese número.");
Console.WriteLine("Escribe un numero entero positivo");

int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("La secuencia de Fibonacci hasta " + num + " es:");
    int a = 0;
    int b = 1;
    int c = 0;
    Console.WriteLine(a);
    Console.WriteLine(b);
    while (c <= num)
    {
        c = a + b;
        if (c <= num)
        {
            Console.WriteLine(c);
        }
        a = b;
        b = c;
    }
}