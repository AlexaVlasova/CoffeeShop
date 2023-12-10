using CoffeeShop.Models;
using CoffeeShop.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CoffeeShop.ViewModels
{
    class SignUpClass
    {
        public ICommand back => new Xamarin.Forms.Command(() => Application.Current.MainPage.Navigation.PopAsync());

    }
}
