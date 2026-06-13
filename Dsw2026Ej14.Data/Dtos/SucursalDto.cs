namespace Dsw2026Ej14.Data.Dtos;

internal class SucursalDto
{
    public Guid Id { get; set; }
    public string Codigo { get; set; } = string.Empty;
    public string Direccion { get; set; } = string.Empty;
    public string Ciudad { get; set; } = string.Empty;
    public Guid ResponsableId { get; set; }
}
