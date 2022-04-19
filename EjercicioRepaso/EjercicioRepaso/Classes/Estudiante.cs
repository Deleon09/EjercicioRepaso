namespace EjercicioRepaso;

public class Estudiante:Persona
{
    
    private string carrera;
    public string Carrera
    {
        get => carrera;
        set => carrera = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Estudiante(string nombreP, string apellidoP, int edadP, string carreraP)
    {
        this.Identificacion = generateDNI();
        this.Nombre = nombreP;
        this.Apellido = apellidoP;
        this.Edad = edadP;
        this.Carrera = carreraP;
    }

    public override string ToString()
    {
        return base.ToString() + $"Carrera: {Carrera}.";
    }
}