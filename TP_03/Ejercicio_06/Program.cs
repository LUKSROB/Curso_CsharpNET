using System;
public class Ejercicio3
{
    public static short ObtenerMes()
    {
        short opcionMes;
        Console.WriteLine("OPC 1: Enero");
        Console.WriteLine("OPC 2: Febrero");
        Console.WriteLine("OPC 3: Marzo");
        Console.WriteLine("OPC 4: Abril");
        Console.WriteLine("OPC 5: Mayo");
        Console.WriteLine("OPC 6: Junio");
        Console.WriteLine("OPC 7: Julio");
        Console.WriteLine("OPC 8: Agosto");
        Console.WriteLine("OPC 9: Septiembre");
        Console.WriteLine("OPC 10: Octubre");
        Console.WriteLine("OPC 11: Noviembre");
        Console.WriteLine("OPC 12: Diciembre");
		Console.Write("Ingrese una opción: ");
		opcionMes=short.Parse(Console.ReadLine());
        if (opcionMes>=1 && opcionMes<=12)
            return opcionMes;
        else
        {
            Console.WriteLine("Opcion invalida.Ingresa de vuelta el mes.");
            return ObtenerMes();
        }
    }
	public static short ObtenerDiasMes(short mes, long anio)
    {
        switch (mes)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                return 31;
            case 4:
            case 6:
            case 9:
            case 11:
                return 30;
            case 2:
                if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
                    return 29;
                else
                    return 28;
            default:
                Console.WriteLine("Valor del mes no valido");
                return 0;
        }
    }
	public static void Main()
    {
        try
        {
            long anio;
            short dia,mes,diaEmbarazo,mesEmbarazo,mesesEmbarazo,diasEmbarazo;
            Console.WriteLine("Ingrese el anio");
            anio=long.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el día");
            dia=short.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes");
            mes=ObtenerMes();
            Console.WriteLine("Ingrese su dia de embarazo");
            diaEmbarazo=short.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su mes de embarazo");
            mesEmbarazo=ObtenerMes();
            if (mes > mesEmbarazo)
                Console.WriteLine("Usted no esta embarazada");
            else
            {
                mesesEmbarazo=(short)(mes-mesEmbarazo);
                Console.WriteLine("Usted lleva "+mesesEmbarazo+"meses de embarazo");
                diasEmbarazo=(short)(dia-diaEmbarazo);
                Console.WriteLine("Con estos dias"+diasEmbarazo);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("ERROR!!!");
        }
    }
}