namespace Dsw2026Ej14.Domain.Entities;

public class Responsable : EntidadBase
{
    public string Nombre { get; init; }
    public string Documento { get; init; }
    public string Telefono { get; init; }

    public Responsable(string nombre, string documento, string telefono, Guid? id = null) :
        base(id)
    {
        Nombre = nombre;
        Documento = documento;
        Telefono = telefono;
    }
}
