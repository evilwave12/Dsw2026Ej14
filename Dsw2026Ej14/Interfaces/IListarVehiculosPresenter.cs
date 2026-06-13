using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej14.Presentation.Interfaces
{
    public interface IListarVehiculosPresenter
    {
        void ListarVehiculos();
        void CalcularConsumos(Dictionary<string, double> vehiculos);
    }
}
