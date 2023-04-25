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
	public partial class splashscreen : ContentPage
	{
		public splashscreen ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
			Animate();
        }
		private async void Animate()
		{
			await Mytext.TranslateTo(0, 0, 1000);
			Mytext.FadeTo(1, 500);
			Myimage.RotateTo(0,1600);
			Myimage.ScaleTo(1, 1800);
			await Task.Delay(1800);
            App.Current.MainPage = new NavigationPage(new Dashboard());


        }
    }
}