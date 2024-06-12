public class Persona
{
	private String nombre;
	private Fecha fechaNacimiento;
	public Persona(String nombre,int dia,int mes,int anio)
	{
		this.nombre=nombre;
		this.fechaNacimiento=new Fecha(dia,mes,anio);
	}
	public String nombre
	{
		get
		{
			return nombre;
		}
		set
		{
			this.nombre=value;
		}
	}
	public Fecha fechaNacimiento()
	{
		get
		{
			return fechaNacimiento;
		}
		set
		{
			this.fechaNacimiento=value;
		}
	}
	public int CalcularEdad(int diaActual,int mesActual,int anioActual)
	{
		int edad=anioActual-fechaNacimiento.anio;
		if(mesActual<fechaNacimiento.mes && diaActual<fechaNacimiento.dia)
			edad--;
		return edad;
	}
}