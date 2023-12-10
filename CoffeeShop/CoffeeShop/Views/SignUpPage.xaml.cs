using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeShop.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage ()
		{
			InitializeComponent ();
		}

        ICommand signUp() 
        {
            return new Command(() =>
            {
                User user = new User();
                SignUpPage page = new SignUpPage();
                CoffeeItemPage item = new CoffeeItemPage();
                page.BindingContext = user;
                Navigation.PushAsync(item);
            });
        }
        private void SignUp_Clicked(object sender, EventArgs e)
        {            
            SignUpPage page = new SignUpPage();                       
            var user = (User)BindingContext;
            page.BindingContext = user;
            if (!String.IsNullOrEmpty(user.Login))
            {
                App.Database.SaveUser(user);
            }
            Navigation.PopAsync();
        }
    }
}