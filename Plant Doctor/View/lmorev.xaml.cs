using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.Graphics.ImageDecoder;

namespace Plant_Doctor.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class lmorev : ContentView
    {
        public lmorev()
        {
            InitializeComponent();
            
            Plant1.Clicked += (Sender, args) =>
            {
                var imageSource = Plant1.Source;
                var Source = imageSource.ToString();
                Console.WriteLine(Source);
                Source = Source.Remove(0, 6);
                Navigation.PushAsync(new NavigationPage(new Plantpage(Source)));
            };
             Plant2.Clicked += (Sender, args) =>
            {
                var imageSource = Plant2.Source;
                var Source = imageSource.ToString();
                Source = Source.Remove(0, 6);
                Navigation.PushAsync(new NavigationPage(new Plantpage(Source)));
            };
             Plant3.Clicked += (Sender, args) =>
            {
                var imageSource = Plant3.Source;
                var Source = imageSource.ToString();
                Source = Source.Remove(0, 6);
                Navigation.PushAsync(new NavigationPage(new Plantpage(Source)));
            };
             Plant4.Clicked += (Sender, args) =>
            {
                var imageSource = Plant4.Source;
                var Source = imageSource.ToString();
                Source = Source.Remove(0, 6);
                Navigation.PushAsync(new NavigationPage(new Plantpage(Source)));
            };
             Plant5.Clicked += (Sender, args) =>
            {
                var imageSource = Plant5.Source;
                var Source = imageSource.ToString();
                Source = Source.Remove(0, 6);
                Navigation.PushAsync(new NavigationPage(new Plantpage(Source)));
            };
        }
        private void Mainsignup(object sender, EventArgs e)
        {
            _ = Navigation.PushModalAsync(new Startup());
            
        }

        private async void Seasonfxn(object sender, EventArgs e)
        {
            if (!(Season.IsVisible == true))
            {
                Seasonbtn.BackgroundColor = Color.LightBlue;
                Plantbtn.BackgroundColor = Color.Transparent;
                Picbtn.BackgroundColor = Color.Transparent;
                Season.Opacity = 0;
                Pic.IsVisible = false;
                Plant.IsVisible = false;
                Season.IsVisible = true;
                await Season.FadeTo(1, 300);
            }
        }
        private async void Plantfxn(object sender, EventArgs e)
        {
            if (!(Plant.IsVisible == true))
            {
                Seasonbtn.BackgroundColor = Color.Transparent;
                Plantbtn.BackgroundColor = Color.LightBlue;
                Picbtn.BackgroundColor = Color.Transparent;
                Plant.Opacity = 0;
                Pic.IsVisible = false;
                Season.IsVisible = false;
                Plant.IsVisible = true;
                await Plant.FadeTo(1, 300);
            }
        }
        private async void Picfxn(object sender, EventArgs e)
        {
            if (!(Pic.IsVisible == true))
            {
                Seasonbtn.BackgroundColor = Color.Transparent;
                Plantbtn.BackgroundColor = Color.Transparent;
                Picbtn.BackgroundColor = Color.LightBlue;
                Pic.Opacity = 0;
                Season.IsVisible = false;
                Plant.IsVisible = false;
                Pic.IsVisible = true;
                await Pic.FadeTo(1, 300);
            }
        }
        private void img1fxn(object sender,EventArgs e)
            {
                var imageSource = s_img1.Source;
        var Source = imageSource.ToString();
        Source = Source.Remove(0, 6);
                Navigation.PushAsync(new NavigationPage(new Seasonpage(Source)));
            }
        private void img2fxn(object sender,EventArgs e)
                {
                    var imageSource = s_img2.Source;
        var Source = imageSource.ToString();
        Source = Source.Remove(0, 6);
                    Navigation.PushAsync(new NavigationPage(new Seasonpage(Source)));
                }
        private void img3fxn(object sender,EventArgs e)
        {
            var imageSource = s_img3.Source;
            var Source = imageSource.ToString();
            Source = Source.Remove(0, 6);
            Navigation.PushAsync(new NavigationPage(new Seasonpage(Source)));
        }
        private void img4fxn(object sender,EventArgs e)
        {
            var imageSource = s_img4.Source;
            var Source = imageSource.ToString();
            Source = Source.Remove(0, 6);
            Navigation.PushAsync(new NavigationPage(new Seasonpage(Source)));
        }
        private void img5fxn(object sender,EventArgs e)
        {
            var imageSource = s_img5.Source;
            var Source = imageSource.ToString();
            Source = Source.Remove(0, 6);
            Navigation.PushAsync(new NavigationPage(new Seasonpage(Source)));
        }
        
    }
}