using SCApp.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCApp
{
    public partial class App : Application
    {
        public static UsuarioManager TodoManager { get; private set; }
        public App()
        {
            InitializeComponent();
            TodoManager = new UsuarioManager(new RestService());
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
