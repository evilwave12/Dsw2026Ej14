using Dsw2026Ej14.Presentation.Presenters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej14.Presentation.Interfaces
{
    internal interface IAgregarVehiculoView
    {
        void SetPresenter(IAgregarVehiculoPresenter presenter);
        void AgregarVehiculo();
    }
}
