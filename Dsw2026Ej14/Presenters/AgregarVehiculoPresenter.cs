using Dsw2026Ej14.Data;
using Dsw2026Ej14.Data.Interfaces;
using Dsw2026Ej14.Domain.Entities;
using Dsw2026Ej14.Presentation.Interfaces;
using Dsw2026Ej14.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej14.Presentation.Presenters
{
    internal class AgregarVehiculoPresenter : IAgregarVehiculoPresenter
    {
        private readonly IAgregarVehiculoView _vista;
        private readonly IPersistencia _persistencia;
        public AgregarVehiculoPresenter(IAgregarVehiculoView vista, IPersistencia persistencia)
        {
            _persistencia = persistencia;
            _vista = vista;
            _vista.SetPresenter(this);
        }

        public void AgregarVehiculo() => _vista.AgregarVehiculo();

        public List<Sucursal> ObtenerSucursales()
        {
            return _persistencia.GetSucursales();
        }

        public bool AgregarVehiculoElectrico(string patente, string marca, string modelo, int anio,
            double capacidadCarga, Sucursal sucursal, double kwhBase)
        {
            VehiculoElectrico vehiculo = new VehiculoElectrico(patente, marca, modelo, anio,
                capacidadCarga, sucursal, kwhBase);
            return _persistencia.AgregarVehiculo(vehiculo);
        }

        public bool AgregarVehiculoCombustible(string patente, string marca, string modelo, int anio,
            double capacidadCarga, Sucursal sucursal, double kilometrosPorLitro, double litrosExtra)
        {
            VehiculoCombustible vehiculo = new VehiculoCombustible(patente, marca, modelo, anio,
                capacidadCarga, sucursal, kilometrosPorLitro, litrosExtra);
            return _persistencia.AgregarVehiculo(vehiculo);
        }
    }
}
