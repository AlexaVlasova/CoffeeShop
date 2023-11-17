using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms.Xaml;

namespace CoffeeShop.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class CoffeeItemViewModel : ViewModelBase
    {
        private ObservableRangeCollection<string> Coffee {  get; }
        public ICommand CallServerCommand { get;}
        string Title;
        public CoffeeItemViewModel() 
        {
            CallServerCommand = new AsyncCommand(CallServer);
            Title = "Товары";
        }

        async Task CallServer() 
        {
            var list = new List<string> { "TEST", "BOTTLE", "CAPPUCHINO" };
            Coffee.AddRange(list);

        }
    }
}
