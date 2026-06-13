namespace Dsw2026Ej14.Domain.Entities;

public abstract class Vehiculo: EntidadBase
{
    public string Patente { get; init; }
    public string Marca { get; init; }
    public string Modelo { get; init; }
    public int Anio { get; init; }
    public double CapacidadCarga { get; init; }
    public Sucursal Sucursal { get; init; }
    public VehiculoTipo Tipo { get; init; }

    protected Vehiculo(VehiculoTipo tipo, string patente, string marca, string modelo, int anio,
        double capacidadCarga, Sucursal sucursal, Guid? id = null) : base(id)
    {
        Patente = patente;
        Marca = marca;
        Modelo = modelo;
        Anio = anio;
        CapacidadCarga = capacidadCarga;
        Sucursal = sucursal;
        Tipo = tipo;
    }

    public abstract double CalcularConsumo(double kilometros);

    public bool EsDe(VehiculoTipo tipo)
    {
        return Tipo == tipo;
    }

    public override string ToString()
    {
        return $"{Marca} {Modelo}";
    }
}
