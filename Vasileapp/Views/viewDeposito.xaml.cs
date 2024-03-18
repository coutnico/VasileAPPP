using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vasileapp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class viewDeposito : ContentPage
	{
		public viewDeposito ()
		{
			InitializeComponent ();
		}

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}