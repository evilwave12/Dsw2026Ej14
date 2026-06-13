namespace Dsw2026Ej14.Domain.Entities;

public class Sucursal: EntidadBase
{
    public string Codigo { get; init; }
    public string Direccion { get; init; }
    public string Ciudad { get; init; }
    public Responsable Responsable { get; init; }

    public Sucursal(string codigo, string direccion, string ciudad, Responsable responsable, Guid? id = null) :
        base(id)
    {
        Codigo = codigo;
        Direccion = direccion;
        Ciudad = ciudad;
        Responsable = responsable;
    }
}
