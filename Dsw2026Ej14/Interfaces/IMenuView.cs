using Dsw2026Ej14.Presentation.Presenters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej14.Presentation.Interfaces
{
    public interface IMenuView
    {
        void SetPresenter(IMenuPresenter menuPresenter);
        void DibujarMenu();
    }
}
