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
	public partial class About : ContentPage
	{
		public About ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
        }
		private void Showalert(object sender, EventArgs e)
		{
			DisplayAlert("Alert","Page is not Avialable","OK");
		}
        private void Backfxn(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        
    }
}