using Dsw2026Ej14.Domain.Entities;

namespace Dsw2026Ej14.Presentation.Views;

public class VehiculoViewModel
{
    public string Patente { get; init; } = string.Empty;
    public string? Vehiculo { get; init; }
    public string? Tipo { get; init; }
    public string? Sucursal { get; init; }
    public double CapacidadCarga { get; init; }
    public double KmPorLitro { get; init; }
    public int Anio { get; init; }
    public double LitrosExtra { get; init; }
    public double KmARecorrer { get; init; }

    public VehiculoViewModel(Vehiculo vehiculo)
    {
        if (vehiculo == null) return;
        Patente = vehiculo.Patente;
        Vehiculo = vehiculo.ToString();
        Tipo = vehiculo.Tipo.ToString();
        Sucursal = vehiculo.Sucursal.Codigo;
        CapacidadCarga = vehiculo.CapacidadCarga;
        Anio = vehiculo.Anio;
        KmPorLitro = vehiculo is VehiculoCombustible combustible ? combustible.KilometrosPorLitro : 0;
        LitrosExtra = vehiculo is VehiculoCombustible combustible1 ? combustible1.LitrosExtra : 0;
        KmARecorrer = 100;
    }
}
