using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms_Login.View;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinForms_Login
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LogIn());
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
