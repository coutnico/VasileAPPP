using Nombredetuproyecto.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Vasileapp.Views;
using Xamarin.Forms;

namespace Vasileapp.ViewModel
{
    public class VmPaginaPrincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONTRUCTOR
        public VmPaginaPrincipal(INavigation navigation)
        {
            Navigation = navigation;
        }


        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }

        #endregion
        #region PROCESOS
        public async Task CambiarVentana()
        {
            await Navigation.PushAsync(new viewProduccion());

        }
        public void ProcesoSimple()
        {

        }

        #endregion
        #region COMANDOS
        public ICommand CambiarVentanacommand => new Command(async () => await CambiarVentana());
        public ICommand procesosimplecomand => new Command(ProcesoSimple);
        #endregion
    }
}
