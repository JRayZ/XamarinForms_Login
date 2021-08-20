using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms_Login.ViewModel;

namespace XamarinForms_Login.View
{ 
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIn : ContentPage
    {
        LogInView logInView;
        public LogIn()
        {
            logInView = new LogInView();
            InitializeComponent();
            BindingContext = logInView;
        }
    }
}  
