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
    public partial class Startup : ContentPage
    {
        public Startup()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
        }

        private void Startsignupfxn(object sender, EventArgs e)
        {
            _ = Navigation.PushModalAsync(new Signup());
        }
        private void Startloginfxn(object sender, EventArgs e)
        {
            _ = Navigation.PushModalAsync(new Login());
        }
    }
}