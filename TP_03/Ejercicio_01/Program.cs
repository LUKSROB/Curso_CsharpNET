using System;
public class Ejercicio1
{
    public static short fecha()
    {
        short opc,mes;
        Console.WriteLine("OPC 1:Enero");
        Console.WriteLine("OPC 2:Febrero");
        Console.WriteLine("OPC 3:Marzo");
        Console.WriteLine("OPC 4:Abril");
        Console.WriteLine("OPC 5:Mayo");
        Console.WriteLine("OPC 6:Junio");
        Console.WriteLine("OPC 7:Julio");
        Console.WriteLine("OPC 8:Agosto");
        Console.WriteLine("OPC 9:Septiembre");
        Console.WriteLine("OPC 10:Octubre");
        Console.WriteLine("OPC 11:Noviembre");
        Console.WriteLine("OPC 12:Diciembre");
        opc=short.Parse(Console.ReadLine());
        if (opc>=1&&opc<=12)
            return opc;
        else
        {
            Console.WriteLine("Ingresa de vuelta el mes");
            mes=fecha();
            return mes;
        }
    }

    public static short dias(short dia,long anio)
    {
        switch (dia)
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
                if (anio%4==0&&anio%100!=0 || anio%400== 0)
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
            short mes1,mes2,aux,i,suma=0;
            Console.WriteLine("Ingrese el anio ");
            anio=long.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 1 mes");
            mes1=fecha();
            Console.WriteLine("Ingrese el 2 mes");
            mes2=fecha();
            if (mes1<=mes2)
            {
                for (i=mes1;i<=mes2;i++)
                    suma+=dias(i,anio);
            }
            else
            {
                aux=mes1;
                mes1=mes2;
                mes2=aux;
                for (i=mes1;i<=mes2;i++)
                    suma+=dias(i, anio);
            }
            Console.WriteLine("los dias que tiene de un mes a otro es"+suma);
        }
        catch (FormatException)
        {
            Console.WriteLine("ERROR!!!");
        }

    }
}
