namespace Dsw2026Ej14.Domain.Entities;

public abstract class EntidadBase
{
    protected EntidadBase(Guid? id = null)
    {
        Id = id ?? Guid.NewGuid();
    }

    public Guid Id { get; }
}
