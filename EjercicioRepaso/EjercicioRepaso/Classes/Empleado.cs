namespace EjercicioRepaso;

public class Empleado:Persona
{
    private string empresa;
    public string Empresa
    {
        get => empresa;
        set => empresa = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public Empleado(string nombreP, string apellidoP, int edadP, string empresaP)
    {
        this.Identificacion = generateDNI();
        this.Nombre = nombreP;
        this.Apellido = apellidoP;
        this.Edad = edadP;
        this.Empresa = empresaP;
    }
    
    public override string ToString()
    {
        return base.ToString() + $"Empresa: {Empresa}.";
    }
}