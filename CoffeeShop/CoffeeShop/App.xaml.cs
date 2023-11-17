
using CoffeeShop.Data;
using CoffeeShop.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeShop
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "CoffeeShop.db";
        public static CoffeeShopRepository database;
        public static CoffeeShopRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new CoffeeShopRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
