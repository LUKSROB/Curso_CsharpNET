Console.WriteLine("Ejericio 04: Pide un número entero positivo y muestra los numeros primos hasta ese número.");
Console.WriteLine("Escribe un numero entero positivo");

int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("Los numeros primos hasta " + num + " son:");
    for (int i = 2; i <= num; i++)
    {
        bool isPrime = true;
        for (int j = 3; j < i; j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.WriteLine(i);
        }
    }
}