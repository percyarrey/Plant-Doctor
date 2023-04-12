using Plant_Doctor.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Plant_Doctor.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private async void Loginfxn(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(email.Text) && !string.IsNullOrEmpty(pwd.Text)){
                var dppath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
                var db = new SQLiteConnection(dppath);
                if (db.GetTableInfo("reguserdata").Count>0)
                {
                    var myquery = db.Table<reguserdata>().Where(u => u.email.Equals(email.Text) && u.pwd.Equals(pwd.Text)).FirstOrDefault();
                    if (myquery != null)
                    {
                        var newname = myquery.fname;
                        newname = "Welcome " + newname +" to the Group One Moblie App";
                        _ = DisplayAlert("Message", newname, "Continue");
                        App.Current.MainPage = new NavigationPage(new MainPage());
                    }
                    else
                    {
                        _ = DisplayAlert("Error", "Wrong Email and Password", "Try Again");
                    }
                }
                else
                {
                    var result= await DisplayAlert("You have No Created Account", "Would you like to Sign Up ","Sign Up","Cancel");
                    if (result)
                    {
                        _ = Navigation.PushModalAsync(new Signup());
                    }

                }
            }
            else
 {
                _ = DisplayAlert("Error", "Please Fill The Information Required", "OK");
            }

        }
        private void Signupfxn(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Signup());
        }
        private void For_pwdfxn(object sender, EventArgs e)
        {
            _ = DisplayAlert("Alert", "Page not Avialable yet", "OK");
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (pwdcheck.IsChecked)
            {
                pwd.IsPassword= false;
            }
            else
            {
                pwd.IsPassword= true;
            }
        }
    }  
}