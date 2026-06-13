namespace Dsw2026Ej14.Domain.Entities;

public class VehiculoCombustible: Vehiculo
{
    public double KilometrosPorLitro { get; init; }
    public double LitrosExtra { get; init; }

    public VehiculoCombustible(string patente, string marca, string modelo, int anio, double capacidadCarga,
        Sucursal sucursal, double kilometrosPorLitro, double litrosExtra, Guid? id = null) : base(VehiculoTipo.Combustible,
            patente, marca, modelo, anio, capacidadCarga, sucursal, id)
    {
        KilometrosPorLitro = kilometrosPorLitro;
        LitrosExtra = litrosExtra;
    }

    public override double CalcularConsumo(double kilometros)
    {
        double extras = DateTime.Now.Year - Anio > 5 ? (kilometros / 15) * LitrosExtra : 0;
        double total = (kilometros / KilometrosPorLitro) + extras;
        return total;
    }
}
