using System;
class Program
{
    public  static int ObtenerAnio()
    {
        Console.WriteLine("Ingresa el anio del evento:");
        return int.Parse(Console.ReadLine());
    }
    static short ObtenerMes()
    {
        short opc;
        Console.WriteLine("Selecciona el mes del evento:");
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
        opc=short.Parse(Console.ReadLine());
        if (opc>=1 && opc<=12)
            return opc;
        else
        {
            Console.WriteLine("Ingresa de vuelta el mes");
            return ObtenerMes();
        }
    }
    public static short ObtenerDia(short mes, int anio)
    {
        short dia,maxDias=ObtenerNumeroDias(mes, anio);;
        Console.WriteLine("Ingresa el día del evento:");
        dia=short.Parse(Console.ReadLine());
        if(dia< 1 || dia>maxDias)
        {
            Console.WriteLine("Dia no valido para el mes y anioo ingresados.");
            return ObtenerDia(mes, anio);
        }
        return dia;
    }
    public static short ObtenerNumeroDias(short mes, int anio)
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
                Console.WriteLine("Valor del mes no válido");
                return 0;
        }
    }
    public static void Main()
    {
        int anio=ObtenerAnio(),frecuencia,i;
        short mes=ObtenerMes(),dia=ObtenerDia(mes, anio);
        Console.WriteLine("Ingresa la frecuencia de ocurrencia de los eventos (en dias):");
        frecuencia=int.Parse(Console.ReadLine());
        Console.WriteLine("\nPróximos eventos:");
        for (i=0;i<5;i++)
        {
            dia = (short)(dia + frecuencia);
            if (dia>ObtenerNumeroDias(mes, anio))
            {
                dia-=ObtenerNumeroDias(mes, anio);
                mes++;
                if (mes > 12)
                {
                    mes = 1;
                    anio++;
                }
            }
            Console.WriteLine($"{anio}-{mes}-{dia}");
        }
    }

}
