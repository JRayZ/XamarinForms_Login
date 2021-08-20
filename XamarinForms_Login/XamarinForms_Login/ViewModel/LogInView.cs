using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms_Login.View;

namespace XamarinForms_Login.ViewModel
{
    public class LogInView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public LogInView()
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
        public Command LogInCommand
        {
            get
            {
                return new Command(Login);
            }
        }
        
        private void Login()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                App.Current.MainPage.DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
            else
            {
                if (Email == "abc@gmail.com" && Password == "1234")
                {
                    App.Current.MainPage.DisplayAlert("Login Success", "", "Ok");
                    App.Current.MainPage.Navigation.PushAsync(new Welcome());
                }
                else
                    App.Current.MainPage.DisplayAlert("Login Fail", "Please enter correct Email and Password", "OK");
            }
        }
    }
}
