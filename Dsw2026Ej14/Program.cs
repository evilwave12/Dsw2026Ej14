using Dsw2026Ej14.Data.Interfaces;
using Dsw2026Ej14.Data;
using Dsw2026Ej14.Presentation.Interfaces;
using Dsw2026Ej14.Presentation.Presenters;
using Dsw2026Ej14.Presentation.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Dsw2026Ej14
{
    public class Program
    {
        static void Main(string[] args)
        {
            var contenedor = new ServiceCollection();
            contenedor.AddTransient<IMenuView,MenuView>();
            contenedor.AddTransient<IMenuPresenter, MenuPresenter>();
            contenedor.AddTransient<IListarVehiculosPresenter, ListarVehiculosPresenter>();
            contenedor.AddTransient<IListarVehiculosView, ListarVehiculosView>();
            contenedor.AddTransient<IAgregarVehiculoPresenter, AgregarVehiculoPresenter>();
            contenedor.AddTransient<IAgregarVehiculoView, AgregarVehiculoView>();
            contenedor.AddTransient<IPersistencia, Persistencia>();

            var provider = contenedor.BuildServiceProvider();

            var menu = provider.GetService<IMenuPresenter>();
            menu.DibujarMenu();
        }
    }
}
