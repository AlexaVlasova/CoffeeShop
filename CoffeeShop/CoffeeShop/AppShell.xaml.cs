
using CoffeeShop.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CoffeeShop
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CoffeeItemPage), typeof(CoffeeItemPage));
        }
    }
}
