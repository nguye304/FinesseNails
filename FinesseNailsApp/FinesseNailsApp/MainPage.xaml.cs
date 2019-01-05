using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinesseNailsApp
{


    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async void OnRootClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        void OnAppClicked(object sender, System.EventArgs e)
        {
           Navigation.PushAsync(new AppointmentPage());
        }

       void OnPriceClicked(object sender, System.EventArgs e)
        {
           Navigation.PushAsync(new PricePage());
        }

       void OnInfoClicked(object sender, System.EventArgs e)
        {
           Navigation.PushAsync(new InfoPage());
        }
    }
}
