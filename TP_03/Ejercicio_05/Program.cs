using System;

public class Ejercicio5
{
    public static long EligePlaneta()
    {
        short opc;
        Console.WriteLine("Elige un planeta:");
        Console.WriteLine("OPC 1: Mercurio");
        Console.WriteLine("OPC 2: Venus");
        Console.WriteLine("OPC 3: Martes");
        Console.WriteLine("OPC 4: Jupiter");
        Console.WriteLine("OPC 5: Saturno");
        Console.WriteLine("OPC 6: Urano");
        Console.WriteLine("OPC 7: Neptuno");
        opc=short.Parse(Console.ReadLine());
        switch (opc)
        {
            case 1:
                return 2312312;
            case 2:
                return 1231231;
            case 3:
                return 23131321;
            case 4:
                return 12312311;
            case 5:
                return 1231231;
            case 6:
                return 1232432;
            case 7:
                return 134313;
            default:
                Console.WriteLine("Opcion invalida, ingrese de vuelta");
                return EligePlaneta();
        }
    }

    public static short EdadTerrestre()
    {
        short edad;
        try
        {
            Console.WriteLine("Ingrese edad terrestre, rango de  1 a 100 años");
            edad = short.Parse(Console.ReadLine());
            while (edad < 1 || edad > 100)
            {
                Console.WriteLine("La edad ingresada está fuera del rango permitido, por favor ingrese de nuevo.");
                Console.WriteLine("Ingrese edad terrestre, rango de  1 a 100 años");
                edad=short.Parse(Console.ReadLine());
            }
            return edad;
        }
        catch (FormatException)
        {
            Console.WriteLine("DATOS ERRONEOS!!"); 
            return EdadTerrestre(); 
        }
    }

    public static long EdadFuera(long raro, short edad)
    {
        return raro/edad;
    }

    public static void Main()
    {
        short edad;
        long edadExtraterrestre;
        edad=EdadTerrestre();
        edadExtraterrestre=EligePlaneta();
        Console.WriteLine("La edad extraterrestre en ese planeta es "+edadExtraterrestre);
    }
}
