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
    public partial class CoffeeItemPage : ContentPage
    {
        public CoffeeItemPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {           
            itemList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        private async void CreateItem(object sender, EventArgs e)
        {
            CoffeeItem item = new CoffeeItem();
            CreateItemPage newItemPage = new CreateItemPage();
            newItemPage.BindingContext = item;
            await Navigation.PushAsync(newItemPage);
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CoffeeItem selectedItem = (CoffeeItem)e.SelectedItem;
            CreateItemPage newItemPage = new CreateItemPage();
            newItemPage.BindingContext = selectedItem;
            await Navigation.PushAsync(newItemPage);
        }

        private void Drinks_Clicked(object sender, EventArgs e)
        {
            itemList.ItemsSource = App.Database.GetItemsByCategory("Coffee");
        }

        private void Bakery_Clicked(object sender, EventArgs e)
        {
            itemList.ItemsSource = App.Database.GetItemsByCategory("Bakery");
        }

        private void Beans_Clicked(object sender, EventArgs e)
        {
            itemList.ItemsSource = App.Database.GetItemsByCategory("Beans");
        }

        private void Additional_Clicked(object sender, EventArgs e)
        {
            itemList.ItemsSource = App.Database.GetItemsByCategory("Additional");
        }

        private void Certificate_Clicked(object sender, EventArgs e)
        {
            itemList.ItemsSource = App.Database.GetItemsByCategory("Certificate");
        }

        private void All_Clicked(object sender, EventArgs e)
        {
            itemList.ItemsSource = App.Database.GetItems();
        }
    }
}