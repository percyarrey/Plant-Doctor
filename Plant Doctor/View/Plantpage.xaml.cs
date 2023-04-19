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
	public partial class Plantpage : ContentPage
	{
		public Plantpage (string imageSource)
		{
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            Console.WriteLine(imageSource);
            if (imageSource != null)
            {
                if (imageSource == "plant2")
                {
                    Headimg.Source = "plant2";
                }
                if (imageSource == "plant3")
                {
                    Headimg.Source = "plant3";

                }
                if (imageSource == "plant5")
                {
                    Headimg.Source = "plant5";
                }
                if (imageSource == "plant4")
                {
                    Headimg.Source = "plant4";
                }
                if (imageSource == "plant6")
                {
                    Headimg.Source = "plant6";
                }
            }
        }
        private void Mainsignup(object sender, EventArgs e)
        {
            _ = Navigation.PushModalAsync(new Startup());
        }
        private void Closefxn(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

    }
}