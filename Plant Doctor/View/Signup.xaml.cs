using Plant_Doctor.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Plant_Doctor.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Signup : ContentPage
	{
		public Signup ()
		{ 
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void Backfxn(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
        private void Ssignupfxn(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fname.Text) && !string.IsNullOrEmpty(lname.Text) && !string.IsNullOrEmpty(email.Text) && !string.IsNullOrEmpty(pwd.Text))
            {   
                if(check.IsChecked == true) {
                    var dppath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
                    var db = new SQLiteConnection(dppath);
                    db.CreateTable<reguserdata>();
                    var item = new reguserdata()
                    {
                        fname = fname.Text,
                        lname = lname.Text,
                        email = email.Text,
                        pwd = pwd.Text,
                        check = check.IsChecked
                    };
                    //Navigation.PopModalAsync();
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        var result= await DisplayAlert("Congratulation", "User Registration Successfull", "Continue", "Cancel");
                        if (result)
                        {
                            await Navigation.PushModalAsync(new login());
                            db.Insert(item);
                        }
                        
                    });
                }
                else
                {
                    DisplayAlert("Error", "Please agree to our TERMS And CONDITION", "OK");
                }
                
            }
            else
            {
                DisplayAlert("Error", "Please Fill The Information Required", "OK");
            }
            
        }
    }
}