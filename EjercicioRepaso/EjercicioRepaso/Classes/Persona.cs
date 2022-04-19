namespace EjercicioRepaso;

public class Persona
{
    public int Identificacion
    {
        get => identificacion;
        set => identificacion = value;
    }

    private int identificacion;
    
    
    private string nombre;
    public string Nombre
    {
        get => nombre;
        set => nombre = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    private string apellido;
    public string Apellido
    {
        get => apellido;
        set => apellido = value ?? throw new ArgumentNullException(nameof(value));
    }

    private int edad;
    public int Edad
    {
        get => edad;
        set => edad = value;
    }
    
    //Métodos
    public int generateDNI()
    {
        Random rnd = new Random();
        return (rnd.Next(10000000, 99999999));
    }

    public override string ToString()
    {
        return $"Información de la persona: \n" +
                          $"Dui: {Identificacion} \n" +
                          $"Nombre: {Nombre} \n" +
                          $"Apellido: {Apellido} \n" +
                          $"Edad: {Edad} \n";
    }
}