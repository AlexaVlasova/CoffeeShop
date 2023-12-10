using CoffeeShop.Data;
using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeShop.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        private async void Login_Clicked(object sender, EventArgs e)
        {
            LoginPage item = new LoginPage();
            IEnumerable<User> users = App.Database.GetUsers();
            User user = users.Where(x => x.Login == login.Text && x.Password == password.Text).FirstOrDefault();       
            LoginPage loginPage = new LoginPage();
            loginPage.BindingContext = item;
            CoffeeItemPage coffeeItemPage = new CoffeeItemPage();
            Navigation.PopAsync();
            //Navigation.
            Navigation.PushAsync(coffeeItemPage);
        }
    }
}