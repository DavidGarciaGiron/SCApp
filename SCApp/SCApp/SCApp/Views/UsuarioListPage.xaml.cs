using SCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsuarioListPage : ContentPage
    {
        public UsuarioListPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.TodoManager.GetTasksAsync();
        }

        async void OnAddUserClicked (object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new UsuarioPage(true)
            {
                BindingContext = e.SelectedItem as Usuario
            });
        }
    }
}