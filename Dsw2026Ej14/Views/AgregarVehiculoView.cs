using Dsw2026Ej14.Domain.Entities;
using Dsw2026Ej14.Presentation.Interfaces;
using Dsw2026Ej14.Presentation.Presenters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej14.Presentation.Views
{
    internal class AgregarVehiculoView : BaseView, IAgregarVehiculoView
    {
        private IAgregarVehiculoPresenter _presenter;

        public AgregarVehiculoView() { }

        public void SetPresenter(IAgregarVehiculoPresenter presenter)
        {
            _presenter = presenter;
        }

        public void AgregarVehiculo()
        {
            LimpiarPantalla();
            DibujarLinea();
            CentrarTexto("Agregar Nuevo Vehículo", out int _);
            DibujarLinea();
            Console.WriteLine();

            string patente = LeerTexto("Patente");
            string marca = LeerTexto("Marca");
            string modelo = LeerTexto("Modelo");
            int anio = LeerEntero("Año");
            double capacidadCarga = LeerDecimal("Capacidad de Carga (kg)");

            Sucursal? sucursal = SeleccionarSucursal();
            if (sucursal == null)
            {
                MostrarMensaje("Error: No se pudo seleccionar una sucursal.");
                return;
            }

            int tipoVehiculo = SeleccionarTipoVehiculo();

            if (tipoVehiculo == 1)
            {
                AgregarVehiculoElectrico(patente, marca, modelo, anio, capacidadCarga, sucursal);
            }
            else if (tipoVehiculo == 2)
            {
                AgregarVehiculoCombustible(patente, marca, modelo, anio, capacidadCarga, sucursal);
            }
        }

        private void AgregarVehiculoElectrico(string patente, string marca, string modelo, int anio,
            double capacidadCarga, Sucursal sucursal)
        {
            Console.WriteLine();
            Console.WriteLine("=== Datos específicos para Vehículo Eléctrico ===");
            double kwhBase = LeerDecimal("kWh Base (por cada 100 km)");

            bool resultado = _presenter.AgregarVehiculoElectrico(patente, marca, modelo, anio,
                capacidadCarga, sucursal, kwhBase);

            if (resultado)
            {
                MostrarMensaje("¡Vehículo eléctrico agregado exitosamente!");
            }
            else
            {
                MostrarMensaje("Error: No se pudo agregar el vehículo eléctrico.");
            }
        }

        private void AgregarVehiculoCombustible(string patente, string marca, string modelo, int anio,
            double capacidadCarga, Sucursal sucursal)
        {
            Console.WriteLine();
            Console.WriteLine("=== Datos específicos para Vehículo de Combustible ===");
            double kmPorLitro = LeerDecimal("Kilómetros por Litro");
            double litrosExtra = LeerDecimal("Litros Extra");

            bool resultado = _presenter.AgregarVehiculoCombustible(patente, marca, modelo, anio,
                capacidadCarga, sucursal, kmPorLitro, litrosExtra);

            if (resultado)
            {
                MostrarMensaje("¡Vehículo de combustible agregado exitosamente!");
            }
            else
            {
                MostrarMensaje("Error: No se pudo agregar el vehículo de combustible.");
            }
        }

        private Sucursal? SeleccionarSucursal()
        {
            Console.WriteLine();
            Console.WriteLine("=== Seleccione una Sucursal ===");

            List<Sucursal> sucursales = _presenter.ObtenerSucursales();

            for (int i = 0; i < sucursales.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sucursales[i].Codigo} - {sucursales[i].Ciudad} ({sucursales[i].Direccion})");
            }

            Console.Write("Seleccione el número de sucursal: ");
            if (int.TryParse(Console.ReadLine(), out int seleccion) && seleccion > 0 && seleccion <= sucursales.Count)
            {
                return sucursales[seleccion - 1];
            }

            return null;
        }

        private int SeleccionarTipoVehiculo()
        {
            Console.WriteLine();
            Console.WriteLine("=== Seleccione el Tipo de Vehículo ===");
            Console.WriteLine("1. Vehículo Eléctrico");
            Console.WriteLine("2. Vehículo de Combustible");
            Console.Write("Seleccione el tipo: ");

            if (int.TryParse(Console.ReadLine(), out int tipo) && (tipo == 1 || tipo == 2))
            {
                return tipo;
            }

            return 0;
        }

        private string LeerTexto(string campo)
        {
            Console.Write($"{campo}: ");
            return Console.ReadLine() ?? string.Empty;
        }

        private int LeerEntero(string campo)
        {
            while (true)
            {
                Console.Write($"{campo}: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    return valor;
                }
                Console.WriteLine("Error: Ingrese un número entero válido.");
            }
        }

        private double LeerDecimal(string campo)
        {
            while (true)
            {
                Console.Write($"{campo}: ");
                if (double.TryParse(Console.ReadLine(), out double valor))
                {
                    return valor;
                }
                Console.WriteLine("Error: Ingrese un número válido.");
            }
        }

        private void MostrarMensaje(string mensaje)
        {
            Console.WriteLine();
            DibujarLinea();
            Console.WriteLine(mensaje);
            DibujarLinea();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
        }
    }
}
