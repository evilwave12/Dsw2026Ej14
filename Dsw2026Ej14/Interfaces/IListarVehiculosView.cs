using Dsw2026Ej14.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej14.Presentation.Interfaces
{
    public interface IListarVehiculosView
    {
        void SetPresenter(IListarVehiculosPresenter presenter);
        void ListarVehiculos(List<VehiculoViewModel> vehiculos);
        void MostrarConsumos(double electricos, double combustible);
    }
}
