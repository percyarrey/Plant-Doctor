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
	public partial class Seasonpage : ContentPage
	{
        public Seasonpage (string imageSource)
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            if (imageSource != null) {
                if(imageSource == "img2")
                {
                    Headtext.Text = "Winter Plant Diseases";
                    Headimg.Source = "img2";
                }
                if (imageSource == "img3")
                {
                    Headtext.Text = "Summer Plant Diseases";
                    Headimg.Source = "img3";

                }
                if (imageSource == "img5")
                {
                    Headtext.Text = "Rainy Plant Diseases";
                    Headimg.Source = "img5";
                }
                if (imageSource == "img4")
                {
                    Headtext.Text = "Autumn Plant Diseases";
                    Headimg.Source = "img4";
                }
                if (imageSource == "img6")
                {
                    Headtext.Text = "Spring Plant Diseases";
                    Headimg.Source = "img6";
                }
            }
        }
        private void Closefxn(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

    }
}