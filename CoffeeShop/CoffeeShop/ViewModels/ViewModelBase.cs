using CoffeeShop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CoffeeShop.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand login => new Xamarin.Forms.Command(() => Application.Current.MainPage.Navigation.PushAsync(new LoginPage()));
        public ICommand sign => new Xamarin.Forms.Command(() => Application.Current.MainPage.Navigation.PushAsync(new SignUpPage()));

    }
}
