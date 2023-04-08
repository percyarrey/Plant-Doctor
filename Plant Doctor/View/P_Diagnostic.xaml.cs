using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Plant_Doctor.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class P_Diagnostic : ContentPage
    {
        public P_Diagnostic()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
        }

        private void P_backfxn(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
        private async void P_subfxn(object sender, EventArgs e)
        {
            var ans = await DisplayAlert("Question?", "Would you like to send you message", "Yes", "No");
            if (ans == true)
            {
               
                _ = DisplayAlert("Alert", "Your message has been send", "OK");
            }
            else
            {
                _ = DisplayAlert("Alert", "Your message has NOT been send", "OK");
            }
        }
    }
}