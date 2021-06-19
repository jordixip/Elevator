
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elevator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        async void On00Clicked(object sender, System.EventArgs e)
        {
            await label.RelRotateTo(360, 1000);
        }

        async void On01Clicked(object sender, System.EventArgs e)
        {
            await label.RelRotateTo(360, 1000);
        }

        async void On02Clicked(object sender, System.EventArgs e)
        {
            await label.RelRotateTo(360, 1000);
        }

        async void On03Clicked(object sender, System.EventArgs e)
        {
            await label.RelRotateTo(360, 1000);
        }

        async void On04Clicked(object sender, System.EventArgs e)
        {
            await label.RelRotateTo(360, 1000);
        }

        async void On05Clicked(object sender, System.EventArgs e)
        {
            await label.RelRotateTo(360, 1000);
        }

        async void On06Clicked(object sender, System.EventArgs e)
        {
            await label.RelRotateTo(360, 1000);
        }

    }
}