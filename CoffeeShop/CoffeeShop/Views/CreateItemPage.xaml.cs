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
    public partial class CreateItemPage : ContentPage
    {
        static List<string> categories = new List<string>() { "Coffee", "Bakery", "Beans" };
		public CreateItemPage()
		{
			InitializeComponent();
            foreach (var item in categories)
            {
                thePicker.Items.Add(item);
            }
            
		}

        private void SaveItem(object sender, EventArgs e)
        {
            var Item = (CoffeeItem)BindingContext;
            if (!String.IsNullOrEmpty(Item.Name))
            {
                App.Database.SaveItem(Item);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteItem(object sender, EventArgs e)
        {
            var Item = (CoffeeItem)BindingContext;
            App.Database.DeleteItem(Item.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}