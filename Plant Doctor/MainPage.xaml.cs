using Plant_Doctor.View;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static SQLite.SQLite3;

namespace Plant_Doctor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            var dppath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dppath);
            if (db.GetTableInfo("reguserdata").Count <= 0)
            {
                Welcomesignup();
            }
        }
        private async void Welcomesignup()
        {
            var result = await DisplayAlert("You have No Created Account", "Would you like to Sign Up ", "Sign Up", "Cancel");
            if (result)
            {
                App.Current.MainPage = new NavigationPage(new Startup());
            }
        }
        private void Mainsignup(object sender, EventArgs e)
        {
            _ = Navigation.PushModalAsync(new Startup());
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
