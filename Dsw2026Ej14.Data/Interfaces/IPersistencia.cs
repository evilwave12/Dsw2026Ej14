using Dsw2026Ej14.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej14.Data.Interfaces
{
    public interface IPersistencia
    {
        List<Vehiculo> GetVehiculos();
        Vehiculo? GetVehiculo(string patente);
        List<Sucursal> GetSucursales();
        bool AgregarVehiculo(Vehiculo vehiculo);
    }
}
