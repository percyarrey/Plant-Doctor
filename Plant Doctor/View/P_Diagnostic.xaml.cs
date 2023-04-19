using Android;
using Android.Content.PM;
using Android.Icu.Number;
using Dalvik.SystemInterop;
using Plugin.Permissions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.Manifest;
using Permission = Android.Manifest.Permission;

namespace Plant_Doctor.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class P_Diagnostic : ContentPage
    {
        private bool isScrolling = false;
        public P_Diagnostic()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            DisplayAlert("Alert", "Scroll down to Upload an image", "OK");
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                
                if (isScrolling)
                {
                    isScrolling = false;
                }
                return true;
            });

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
                _ = DisplayAlert("Alert", "Your message has been NOT send", "OK");
            }
        }
        private async void Closefxn(object sender,EventArgs e)
        {
            await Framelayout.ScaleTo(0, 100);
            Toplayout.IsVisible = false;
            Toplayout.IsEnabled = false;
            await Framelayout.ScaleTo(1);
        }
        private async void P_doactionfxn(object sender, EventArgs e)
        {
            Toplayout.IsVisible = true;
            Toplayout.IsEnabled = true;
            Framelayout.Scale = 0;
            await Framelayout.ScaleTo(1,300);
        }
        private async void P_uploadfxn(object sender, EventArgs e)
        {
            await Framelayout.ScaleTo(0, 100);
            Toplayout.IsVisible = false;
            Toplayout.IsEnabled = false;
            Uploadimg();
            await Framelayout.ScaleTo(1);
            
        }
        private async void P_capfxn(object sender, EventArgs e)
        {
            await Framelayout.ScaleTo(0, 100);
            Toplayout.IsVisible = false;
            Toplayout.IsEnabled = false;
            Capimg();
            await Framelayout.ScaleTo(1);
            

        }
        private void Mainsignup(object sender, EventArgs e)
        {
            _ = Navigation.PushModalAsync(new Startup());
        }
        private async void Uploadimg()
        {
            if (MediaPicker.IsCaptureSupported)
            {
                try
                {
                    var photo = await MediaPicker.PickPhotoAsync();
                    await LoadPhotoAsync(photo);
                }
                catch (FeatureNotSupportedException fx)
                {
                    await DisplayAlert("Alert", $"Device is not supported: {fx.Message}", "ok");
                }
                catch (PermissionException pex)
                {
                    await DisplayAlert("Alert", $"Permission failed: {pex.Message}", "ok");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Alert", $"Something went wrong: {ex.Message}", "ok");
                }
            }
        }
        private async void Capimg()
        {
            if (MediaPicker.IsCaptureSupported)
            {
                try
                {
                    var photo = await MediaPicker.CapturePhotoAsync();
                    await LoadPhotoAsync(photo);
                }
                catch (FeatureNotSupportedException fx)
                {
                    await DisplayAlert("Alert", $"Device is not supported: {fx.Message}", "ok");
                }
                catch (PermissionException pex)
                {
                    await DisplayAlert("Alert", $"Permission failed: {pex.Message}", "ok");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Alert", $"Something went wrong: {ex.Message}", "ok");
                }
            }
        }
        private async Task LoadPhotoAsync(FileResult photo)
        {
            if (photo == null)
            {
                return;
            }
            var newfile = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
            using (var stream = await photo.OpenReadAsync())
            using (var newstream = File.OpenWrite(newfile))
                await stream.CopyToAsync(newstream);
            Image Myimg = new Image { Source=$"{newfile}",HeightRequest=140};
            await Myimg.ScaleXTo(1.4,0);
            var stacklay = new StackLayout { Spacing=0,Padding=0};
            var flexLayout = new FlexLayout { Direction=FlexDirection.Row,JustifyContent=FlexJustify.SpaceBetween, AlignItems=FlexAlignItems.Center,Padding = new Thickness(10)};
            var imgbtn = new ImageButton { Source = "deleteicon.png", HeightRequest = 35 };
            var frame = new Frame { Padding = 4, HasShadow = true,  Margin = 0, IsClippedToBounds =true,CornerRadius =5 };
            var imgframe = new Frame { HasShadow = true, Margin = 0, IsClippedToBounds = true, CornerRadius = 8 };
            var boxview = new BoxView {BackgroundColor=Color.White,HeightRequest=1,ScaleX=2 };
            frame.Content = imgbtn;
            imgframe.Content = Myimg;
            flexLayout.Children.Add(imgframe);
            flexLayout.Children.Add(frame);
            stacklay.Children.Add(flexLayout);
            stacklay.Children.Add(boxview);
            imgcontrol.Children.Add(stacklay);
            imgbtn.Clicked += (sender, args) =>
            {
                imgcontrol.Children.Remove(stacklay);
            };
        }
        private void Scrollfxn(object sender, EventArgs e)
        {

            if (!isScrolling)
            {
                if (Myscroller.ScrollY ==0)
                {
                    isScrolling = true;
                    Hideonscroll.IsVisible = true;
                }
                else if(Myscroller.ScrollY!=0)
                {
                    isScrolling = true;
                    Hideonscroll.IsVisible = false;
                }
            }
            isScrolling = true;
        }
        private void Resultfxn(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new Result()));
        }
    }
}