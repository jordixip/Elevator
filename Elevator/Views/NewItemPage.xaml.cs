using Elevator.Models;
using Elevator.ViewModels;
using Xamarin.Forms;

namespace Elevator.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}