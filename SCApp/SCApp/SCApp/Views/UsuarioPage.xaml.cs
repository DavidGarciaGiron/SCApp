using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsuarioPage : ContentPage
    {
        bool isNewUser;
        public UsuarioPage(bool isNew = false)
        {
            InitializeComponent();
            isNewUser = isNew;
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var todoUser = (Usuario)BindingContext;
            await App.TodoManager.SaveTaskAsync(todoUser, isNewUser);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e) {
            var todoUser = (Usuario)BindingContext;
            await App.TodoManager.DeleteTaskAsync(todoUser);
            await Navigation.PopAsync();
        }
        async void OnCancelButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}