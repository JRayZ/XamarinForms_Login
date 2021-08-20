using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms_Login.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIn : ContentPage
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LoginBtnClicked(object sender, EventArgs e)
        {  
            if (string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(Password.Text))
                DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
            else
            {
                if (Email.Text == "jhonatan@gmail.com" && Password.Text == "abcde123")
                {
                    DisplayAlert("Login Success", "", "Ok");
                    Navigation.PushAsync(new Welcome());
                }
                else
                {
                    DisplayAlert("Login Fail", "Please enter correct Email and Password", "OK");
                }
            }
        }

    }
}