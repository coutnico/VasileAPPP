using Nombredetuproyecto.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Vasileapp.ViewModel
{
    public class Vmpatron : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONTRUCTOR
        public Vmpatron(INavigation navigation)
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
        public async Task ProcesoEspera()
        {

        }
        public void ProcesoSimple()
        {

        }

        #endregion
        #region COMANDOS
        public ICommand Procesocommand => new Command(async()=>await ProcesoEspera());
        public ICommand procesosimplecomand => new Command(ProcesoSimple);
        #endregion

    }
}
