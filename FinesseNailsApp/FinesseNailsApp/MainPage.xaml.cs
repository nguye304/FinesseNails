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
            /*
            var grid = new Grid();

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var topLeft = new Label { Text = "Top Left" };
            var topRight = new Label { Text = "Top Right" };
            var bottomLeft = new Label { Text = "Bottom Left" };
            var bottomRight = new Label { Text = "Bottom D Right" };

            grid.Children.Add(topLeft, 0, 0);
            grid.Children.Add(topRight, 1, 0);
            grid.Children.Add(bottomLeft, 0, 1);
            grid.Children.Add(bottomRight, 1, 1);
            */
        }

        async void OnRootClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();//go back to home
        }

        void OnAppClicked(object sender, System.EventArgs e)
        {
           Navigation.PushAsync(new AppointmentPage());//Make an Appointment Page
        }

       void OnContactClicked(object sender, System.EventArgs e)
        {
           Navigation.PushAsync(new ContactPage());//PricePage
        }

       void OnInfoClicked(object sender, System.EventArgs e)
        {
           Navigation.PushAsync(new InfoPage());//EmployeeInfoPage
        }

        private void OnPriceClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PricePage());//Price,Location,Hours Page
        }
    }
}
