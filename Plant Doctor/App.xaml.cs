using Plant_Doctor.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("bootstrap-icons.ttf", Alias = "Bootstrap")]
namespace Plant_Doctor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage =new NavigationPage(new Dashboard());
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
