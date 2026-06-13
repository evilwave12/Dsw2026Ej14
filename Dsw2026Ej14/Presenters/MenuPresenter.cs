using Dsw2026Ej14.Presentation.Interfaces;
using Dsw2026Ej14.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej14.Presentation.Presenters
{
    public class MenuPresenter : IMenuPresenter
    {
        private readonly IMenuView _vista;
        private readonly IListarVehiculosPresenter _listarPresenter;
        private readonly IAgregarVehiculoPresenter _agregarPresenter;
        public MenuPresenter(IMenuView view, IListarVehiculosPresenter listarPresenter, IAgregarVehiculoPresenter agregarPresenter)
        {
            _vista = view;
            _listarPresenter = listarPresenter;
            _agregarPresenter = agregarPresenter;
            _vista.SetPresenter(this);
        }

        public void DibujarMenu()
        {
            _vista.DibujarMenu();
        }

        public void ListarVehiculos()
        {
            _listarPresenter.ListarVehiculos();
        }

        public void AgregarVehiculo()
        {
            _agregarPresenter.AgregarVehiculo();
        }
    }
}
