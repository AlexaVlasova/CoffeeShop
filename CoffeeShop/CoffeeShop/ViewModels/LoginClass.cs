using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CoffeeShop.ViewModels
{
    internal class LoginClass
    {
        public ICommand back => new Xamarin.Forms.Command(() => Application.Current.MainPage.Navigation.PopAsync());

    }
}
