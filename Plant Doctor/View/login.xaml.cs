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
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void Loginfxn(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(email.Text) && !string.IsNullOrEmpty(pwd.Text)){
                var dppath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
                var db = new SQLiteConnection(dppath);
                var myquery = db.Table<reguserdata>().Where(u => u.email.Equals(email.Text) && u.pwd.Equals(u.email)).FirstOrDefault();
                if (myquery != null)
                {
                    DisplayAlert("Message", "Welcome Back", "Continue");
                    App.Current.MainPage = new NavigationPage(new MainPage());
                }
                else
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        DisplayAlert("Error", "Wrong Login and SignUp", "Continue");
                    });
                }
            }
            else{
                DisplayAlert("Error", "Please Fill The Information Required", "OK");
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
        
    }  
}