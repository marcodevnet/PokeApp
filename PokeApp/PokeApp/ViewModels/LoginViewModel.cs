using PokeApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace PokeApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public LoginViewModel()
        {

        }
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public Command LoginCommand
        {
            get
            {
                return new Command(Login);
            }
        }

        private void Login()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                App.Current.MainPage.DisplayAlert("Error", "Por favor ingresa correo electronico y contraseña", "OK");
            else
            {
                if (Email == "prueba@gmail.com" && Password == "1234")
                {
                    App.Current.MainPage.Navigation.PushAsync(new AllPokemonPage());
                }
                else
                    App.Current.MainPage.DisplayAlert("Error", "Correo electronico y/o contraseña incorrecta", "OK");
            }
        }

    }
    
}
