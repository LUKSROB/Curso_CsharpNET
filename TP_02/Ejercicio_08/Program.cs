Console.WriteLine("Ejercicio 08: Pide una cadena de texto y cuenta las vocales que contiene.");
Console.WriteLine("Escribe una cadena de texto");

string cadena = Console.ReadLine();
int contador = 0;

for (int i = 0; i < cadena.Length; i++)
{
    if ("aeiouAEIOU".Contains(cadena[i]))
    {
        contador++;
    }
}

Console.WriteLine("La cadena de texto tiene " + contador + " vocales.");