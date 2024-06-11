using System;
public class Ejercicio2
{
    public static short ObtenerHora()
    {
        short hora;
        do
        {
            Console.Write("Ingrese hora en rango de 0 a 23: ");
            hora=short.Parse(Console.ReadLine());
        }
        while(hora<0 || hora>23);
        return (short)hora;
    }
	public static void Main()
    {
        try
        {
            short horaEntrada, horaSalida, horasTotal;
            do
            {
                Console.WriteLine("Ingrese la hora de entrada: ");
                horaEntrada=ObtenerHora();
                Console.WriteLine("Ingrese la hora de salida: ");
                horaSalida=ObtenerHora();
            }
            while (horaEntrada >= horaSalida);
			horasTotal=(short)(horaSalida-horaEntrada);
            Console.WriteLine("La cantidad de horas trabajadas es:"+horasTotal);
        }
        catch (FormatException)
        {
            Console.WriteLine("ERROR!!!");
        }
    }
}