using Android.Widget;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinesseNailsApp
{

  
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KeyInfoPage : ContentPage
    {

        ObservableCollection<string> HourStrings = new ObservableCollection<string>();

        public KeyInfoPage()
        {
           
            InitializeComponent();
            PopulateHours();//provides strings for listview
            HighlightToday();//highlights the list view according to todays date
            PopulatePrice();
        }

        private void PopulatePrice()
        {
            var itemCollection = new ObservableCollection<Item>();
            var item1 = new Item
            {
                Name = "Pedicure1",
                Price = 10100,
            };
            var item2 = new Item
            {
                Name = "Pedicure2",
                Price = 10020,
            };
            var item3 = new Item
            {
                Name = "Pedicure3",
                Price = 41000,
            };

            itemCollection.Add(item1);
            itemCollection.Add(item2);
            itemCollection.Add(item3);

            PriceListView.ItemsSource = itemCollection;




        }

        private void PopulateHours()
        {//provides strings for hours list view
            var Monday = "Monday:    9:00 am - 7:00pm ";
            var Tuesday = "Tuesday:   9:00 am - 7:00pm ";
            var Wednesday = "Wednesday: 9:00 am - 7:00pm ";
            var Thursday = "Thursday:  9:00 am - 7:00pm ";
            var Friday = "Friday:    9:00 am - 7:00pm ";
            var Saturday = "Saturday:  9:00 am - 6:00pm ";
            var Sunday = "Sunday:    11:00 am - 5:00pm ";

            HourStrings.Add(Monday);
            HourStrings.Add(Tuesday);
            HourStrings.Add(Wednesday);
            HourStrings.Add(Thursday);
            HourStrings.Add(Friday);
            HourStrings.Add(Saturday);
            HourStrings.Add(Sunday);


            HoursListView.ItemsSource = HourStrings;

        }

        private void HighlightToday()
        {//will highlight the day according to date
            /*
            HoursListView.SetSelector(Android.Resource.Color.Transparent;
            HoursListView.CacheColorHint = Color.Transparent.ToAndroid();
            DateTime today = DateTime.Now;//gets todays date format "M/dd/yyyy hh:mm:ss tt"
            var Day = today.ToString("dddd");
            Console.WriteLine(Day);
            */


        }

    }

}