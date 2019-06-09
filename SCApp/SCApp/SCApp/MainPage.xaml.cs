using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SCApp.Views;
using Xamarin.Forms.Xaml;

namespace SCApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();

            btnIniciar.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new UsuarioListPage());
            };
        }
	}
}