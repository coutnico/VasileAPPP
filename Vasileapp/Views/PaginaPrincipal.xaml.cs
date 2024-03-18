using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Vasileapp.Views;
using Vasileapp.ViewModel;

namespace Vasileapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new VmPaginaPrincipal(Navigation); 
        }

        
    }
}
