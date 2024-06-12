public class Fecha
{
	private int dia,mes,anio;
	public Fecha(int dia,int mes,int anio)
	{
		this.dia=dia;
		this.mes=mes;
		this.anio=anio;
	}
	public int Dia()
	{
		get
		{
			return dia;
		}
		set
		{
			dia=value;
		}
	}
	public int Mes()
	{
		get
		{
			return mes;
		}
		set
		{
			mes=value;
		}
	}
	publix int Anio()
	{
		get
		{
			return anio;
		}
		set
		{
			anio=value;
		}
	}
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
        opcionMes = short.Parse(Console.ReadLine());
        if (opcionMes >= 1 && opcionMes <= 12)
            return opcionMes;
        else
        {
            Console.WriteLine("Opción inválida. Ingresa de vuelta el mes.");
            return ObtenerMes();
        }
    }

    public static short ObtenerDiasMes(short mes, int anio)
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
}