using Plant_Doctor.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Plant_Doctor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
        }
        private void Mainsignup(object sender, EventArgs e)
        {
           Navigation.PushModalAsync(new login());
        }
        private void P_Diagnosticfxn(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new P_Diagnostic());
        }
        private void Aboutfxn(object sender, EventArgs e)
        {

            _ = DisplayAlert("Alert", "Page not Avialable", "OK");
        }
    }
}
