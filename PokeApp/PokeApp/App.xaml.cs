using PokeApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
            //Aplication.Current.Properties["key"] = value;

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
