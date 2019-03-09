using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace FinesseNailsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppointmentPage : ContentPage
	{
		public AppointmentPage ()
		{
			InitializeComponent ();
		}

        async void OnRootClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        DatePicker datePicker = new DatePicker
        {
            MinimumDate = new DateTime(2019,1,1),
            MaximumDate = new DateTime(2019,12,31),
            Date = new DateTime(2019,7,12),
            

        };
        TimePicker timePicker = new TimePicker
        {
            Time = new TimeSpan(4,15,26)//set to 04:14:26 so hour, mi
        };

        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            DisplayAlert("Selected Date is: ", "TIME IS HERE ", "OK");
        }
        //TODO: 


    }
}