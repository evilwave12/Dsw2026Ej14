namespace Dsw2026Ej14.Data.Dtos;

internal class VehiculoDto
{
    public Guid? Id { get; set; }
    public string Tipo { get; set; } = string.Empty;
    public string Patente { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public int Anio { get; set; }
    public double CapacidadCarga { get; set; }
    public Guid SucursalId { get; set; }
    public double KwhBase { get; set; }
    public double KilometrosPorLitro { get; set; }
    public double LitrosExtra { get; set; }
}
