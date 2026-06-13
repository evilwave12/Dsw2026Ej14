using System;
using System.Collections.Generic;
using System.Text;
using Dsw2026Ej14.Presentation.Interfaces;

namespace Dsw2026Ej14.Presentation.Views
{
    internal class ListarVehiculosView : BaseView, IListarVehiculosView
    {
        private IListarVehiculosPresenter _presenter;
        public ListarVehiculosView() { }

        public void SetPresenter(IListarVehiculosPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ListarVehiculos(List<VehiculoViewModel> vehiculos)
        {
            LimpiarPantalla();
            string[] columnas = { "Patente", "Vehículo", "Tipo", "Cap. Carga", "Km/l", "Año", "L.Extra", "Kms a recorrer" };
            DibujarEncabezado(columnas);

            DibujarDatos(columnas.Length, vehiculos);

            DibujarLinea();

            Console.Write("\n");
            Console.Write("\n");
            Console.WriteLine("Presione una tecla para calcular el total de consumos...");
            Console.ReadLine();
            Dictionary<string, double> vehiculosDict = [];
            foreach (VehiculoViewModel vehiculo in vehiculos)
            {
                vehiculosDict.Add(vehiculo.Patente, vehiculo.KmARecorrer);
            }
            _presenter.CalcularConsumos(vehiculosDict);
        }

        public void MostrarConsumos(double electricos, double combustible)
        {
            DibujarLinea();
            Console.WriteLine($"Total consumo Vehículos Eléctricos: {electricos:N2} kWh");
            Console.WriteLine($"Total consumo Vehículos Combustible: {combustible:N2} Litros");
            DibujarLinea();
            Console.Write("\n");
            Console.Write("\n");
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadLine();
        }

        private void DibujarDatos(int columnas, List<VehiculoViewModel> vehiculos)
        {
            int ancho = Console.WindowWidth / columnas;
            foreach (var vehiculo in vehiculos)
            {
                Console.Write("|");
                CentrarTexto(vehiculo.Patente, out int l, ancho - 1, false);
                Console.Write("".PadRight(ancho - 1 - l));
                Console.Write("|");
                CentrarTexto(vehiculo.Vehiculo, out l, ancho - 1, false);
                Console.Write("".PadRight(ancho - 1 - l));
                Console.Write("|");
                CentrarTexto(vehiculo.Tipo, out l, ancho - 1, false);
                Console.Write("".PadRight(ancho - 1 - l));
                Console.Write("|");
                CentrarTexto(vehiculo.CapacidadCarga.ToString(), out l, ancho - 1, false);
                Console.Write("".PadRight(ancho - 1 - l));
                Console.Write("|");
                CentrarTexto(vehiculo.KmPorLitro.ToString(), out l, ancho - 1, false);
                Console.Write("".PadRight(ancho - 1 - l));
                Console.Write("|");
                CentrarTexto(vehiculo.Anio.ToString(), out l, ancho - 1, false);
                Console.Write("".PadRight(ancho - 1 - l));
                Console.Write("|");
                CentrarTexto(vehiculo.LitrosExtra.ToString(), out l, ancho - 1, false);
                Console.Write("".PadRight(ancho - 1 - l));
                Console.Write("|");
                CentrarTexto(vehiculo.KmARecorrer.ToString(), out l, ancho - 1, false);
                Console.Write("".PadRight(ancho - 1 - l));
            }
        }
    }
}
